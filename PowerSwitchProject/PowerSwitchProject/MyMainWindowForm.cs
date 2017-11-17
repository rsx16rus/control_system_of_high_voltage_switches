using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Data.Entity;
using System.Windows;

namespace PowerSwitchProject
{
    public partial class MyMainWindowForm : Form
    {
        User user;
        UserContext myUserContext;
        public MyMainWindowForm()
        {
            InitializeComponent();
        }

        public MyMainWindowForm(User u)
        {
            user = u;            
            myUserContext = MyLocalData.userContext;//не забывай указывать Local

            { //текст в кнопках вывода количества изношенных ВВ
                Switch_Counting counting = new Switch_Counting();
                int numOfKZ = counting.NumberOfSwitch_ShortCircuits(myUserContext);
                button_NumberOf_KZ.Text = "Количество ВВ    с пределом     КЗ =     " + numOfKZ;
                int numOfMex = counting.NumberOfSwitch_MechanicalShutdowns(myUserContext);
                button_NumberOf_Mehiznos.Text = "Количество ВВ с пределом износа = " + numOfMex;
            }

            //Наполнение кнопками с именами электроподстанций (Блок готов)
            foreach (var electricalSubstation in myUserContext.Electrical_Substations.Local)
            {
                Button_Fill bf = new Button_Fill();
                Button newButton = bf.Button_Plus(("PS_Id_" + Convert.ToString(electricalSubstation.Id)), electricalSubstation.Name_Electrical_Substation, 140, 50);//Проверь какое Name присваивается Button
                {   //задаю значение Margin
                    var margin = newButton.Margin;
                    margin.All = 10;
                    newButton.Margin = margin;
                }
                newButton.Click += new EventHandler(this.PS_Id_Click);
                flowLayoutPanel_PStancii.Controls.Add(newButton);
            }
            if (user.UserType == "Начальник ГПС") //(Блок готов)
            {
                Button_Fill bf = new Button_Fill();
                Button insertPS = bf.Button_Plus("insertPS_Button", "+ Новая подстанция", 140, 50); //Проверь какое Name присваивается Button  
                {   //задаю значение Margin
                    var margin = insertPS.Margin;
                    margin.All = 10;
                    insertPS.Margin = margin;
                }
                insertPS.Click += new EventHandler(this.insertPS_Button_Click);
                flowLayoutPanel_PStancii.Controls.Add(insertPS);
            }

        }

        private void PS_Id_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_10kB.Controls.Clear();
            flowLayoutPanel_35kB.Controls.Clear();
            flowLayoutPanel_110_more_kB.Controls.Clear();
            //try
            //{            
            string Id_PS = (((Button)sender).Name).Substring(6);//извлекаем Id_Electrical_Substation
            int electrical_Substation_Id = Convert.ToInt32(Id_PS);
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    MessageBox.Show("Ошибка в имени кнопки ПС");
            //    return;
            //}

            //название выбранной ПС
            //List_of list_of = new List_of();
            Electrical_Substation selectedElectrical_Substation = myUserContext.Electrical_Substations.Local.Single(u => u.Id == electrical_Substation_Id);
                        
            int[] voltage = new int[] { 10, 35, 110, 220 };
            FlowLayoutPanel[] panels = new FlowLayoutPanel[] { flowLayoutPanel_10kB, flowLayoutPanel_35kB, flowLayoutPanel_110_more_kB, flowLayoutPanel_110_more_kB };
            List_of_switches list_Of_Switches = new List_of_switches();
            for (int i = 0; i < voltage.Length; i++)
            {
                var Operating_swithes_of_PS = list_Of_Switches.Create_a_list_of_switches(selectedElectrical_Substation, voltage[i], myUserContext);

                //Создание кнопок ВВ
                foreach (var Oper_switch in Operating_swithes_of_PS)//(Блок готов)
                {
                    Button_Fill bf = new Button_Fill();
                    Button newButton = bf.Button_Plus(("Switch_Id_" + Convert.ToString(Oper_switch.Id)), Oper_switch.Dispatching_name, 130, 40);//Проверь какое Name присваивается Button                       
                    {   //задаю значение Margin
                        var margin = newButton.Margin;
                        margin.Left = 35;
                        margin.Right = 0;
                        margin.Top = 10;
                        margin.Bottom = 10;
                        newButton.Margin = margin;
                    }
                    newButton.Click += new EventHandler(this.VV_Click);
                    panels[i].Controls.Add(newButton);
                }
                if (user.UserType == "Начальник ГПС")//(Блок готов)
                {

                    Button_Fill bf = new Button_Fill();
                    Button insertOperSw = bf.Button_Plus("insertOperSw_Button", "+ Новый выключатель", 130, 40);//Проверь какое Name присваивается Button                    
                    {   //задаю значение Margin
                        var margin = insertOperSw.Margin;
                        margin.Left = 35;
                        margin.Right = 0;
                        margin.Top = 10;
                        margin.Bottom = 10;
                        insertOperSw.Margin = margin;
                    }
                    if (i < 3)
                    {
                        insertOperSw.Click += new EventHandler(this.insertOperSw_Button_Click);
                        panels[i].Controls.Add(insertOperSw);
                    }
                }
            }
        }
        //Остановился здесь!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void insertPS_Button_Click(object sender, EventArgs e)
        {
            Form_insertPS formInsertPS = new Form_insertPS(this);
            formInsertPS.Show();
        }
        private void insertOperSw_Button_Click(object sender, EventArgs e)
        {
            Form_OperationSwitch_New formOperSwNew = new Form_OperationSwitch_New();
            formOperSwNew.Show();
        }

        //Событие для кнопок ВВ
        private void VV_Click(object sender, EventArgs e)
        {
            //try
            //{
            string id_VV = (((Button)sender).Name).Substring(10);//извлекаем Id_Operating_Switch
            int oper_switch_Id = Convert.ToInt32(id_VV);
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    MessageBox.Show("Ошибка в имени кнопки ПС");
            //    return;
            //}

            if (user.UserType == "Начальник ГПС" | user.UserType == "ПТО" | user.UserType == "Руководство")
            {
                Form_OperationSwitch OperSwForm = new PowerSwitchProject.Form_OperationSwitch(oper_switch_Id);
                OperSwForm.Show();
            }
            else if (Program.user.UserType == "Диспетчер РЭС")
            {
                DispetcherInsertedForm DispForm = new DispetcherInsertedForm(oper_switch_Id);
                DispForm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка: У пользователя нет доступа!");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }


    class Button_Fill //(Готов)
    {
        //public Button Button_Ps_Filling(UserContext db, Electrical_Substation elsub)
        //{
        //    //Создание кнопок подстанций
        //    Button newButton = new Button();
        //    newButton.Name = "PS_Id_" + Convert.ToString(elsub.Id);
        //    newButton.BackColor = Color.Silver;
        //    newButton.Text = elsub.Name_Electrical_Substation;
        //    newButton.Size = new Size(140, 50);            
        //    return newButton;
        //}
        public Button Button_Plus(string button_name, string button_text, int width, int height)
        {
            Button newButton = new Button();
            newButton.Name = button_name;
            newButton.BackColor = Color.Silver;
            newButton.Text = button_text;
            newButton.Size = new Size(width, height);
            return newButton;
        }
    }
}

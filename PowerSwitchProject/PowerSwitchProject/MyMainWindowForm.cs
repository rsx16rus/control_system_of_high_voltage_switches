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
        public MyMainWindowForm()
        {
            InitializeComponent();
        }

        public MyMainWindowForm(User u)
        {
            user = u;
            UserContext myLocalData;
            MyLocalData obj = new MyLocalData();
            myLocalData = obj.DataFill();

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void MyMainWindowForm_Load(object sender, EventArgs e)
        {
            List_of list_of = new List_of();
            IOrderedQueryable<Electrical_Substation> electricalSubstation_List = list_of.Searched_PS(Program.user);
            { //текст в кнопках вывода количества изношенных ВВ
                Number_of_Switches numOfsw = new Number_of_Switches();
                int numOfKZ = numOfsw.NumberOfSwitch_ShortCircuits(electricalSubstation_List);
                //int numOfMex = numOfsw.NumberOfSwitch_MechanicalShutdowns(electricalSubstation_List);
                button_NumberOf_KZ.Text = "Количество ВВ    с пределом     КЗ =     " + numOfKZ;
                int numOfMex = numOfsw.NumberOfSwitch_MechanicalShutdowns(electricalSubstation_List);
                button_NumberOf_Mehiznos.Text = "Количество ВВ с пределом износа = " + numOfMex;
            }
            //Создание кнопок подстанций
            foreach (var electricalSubstation in electricalSubstation_List)
            {
                Button newButton = new Button();
                newButton.Name = "PS_Id_" + Convert.ToString(electricalSubstation.Id_Electrical_Substation);
                newButton.BackColor = Color.Silver;
                newButton.Text = electricalSubstation.Name_Electrical_Substation;
                newButton.Size = new Size(140, 50);
                {   //задаю значение Margin
                    var margin = newButton.Margin;
                    margin.All = 10;
                    newButton.Margin = margin;
                }
                newButton.Click += new EventHandler(this.PS_Id_Click);
                flowLayoutPanel_PStancii.Controls.Add(newButton);
            }
            if (Program.user.UserType == "Начальник ГПС")
            {
                Button insertPS = new Button();
                insertPS.Name = "insertPS_Button";
                insertPS.BackColor = Color.WhiteSmoke;
                insertPS.Text = "+ Новая подстанция";
                insertPS.Size = new Size(140, 50);
                {
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
            List_of list_of = new List_of();
            label_Selected_PS.Text = list_of.Label_Text_SelectedPS(electrical_Substation_Id);

            int[] voltage = new int[] { 10, 35, 110, 220 };
            FlowLayoutPanel[] panels = new FlowLayoutPanel[] { flowLayoutPanel_10kB, flowLayoutPanel_35kB, flowLayoutPanel_110_more_kB, flowLayoutPanel_110_more_kB };
            for (int i = 0; i < voltage.Length; i++)
            {
                IEnumerable<Operating_switch> Operating_swithes_of_PS = list_of.Operating_switches_of_PS(electrical_Substation_Id, voltage[i]);

                //Создание кнопок ВВ
                foreach (var Oper_switch in Operating_swithes_of_PS)
                {
                    Button newButton = new Button();
                    newButton.Name = "Switch_Id_" + Convert.ToString(Oper_switch.Id_Operating_switch);
                    newButton.BackColor = Color.Silver;
                    newButton.Text = Oper_switch.Dispatching_name;
                    newButton.Size = new Size(130, 40);
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
                if (Program.user.UserType == "Начальник ГПС")
                {
                    Button insertOperSw = new Button();
                    insertOperSw.Name = "insertOperSw_Button";
                    insertOperSw.BackColor = Color.WhiteSmoke;
                    insertOperSw.Text = "+ Новый выключатель";
                    insertOperSw.Size = new Size(130, 40);
                    {
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

        private void insertPS_Button_Click(object sender, EventArgs e)
        {
            Form_insertPS formInsertPS = new PowerSwitchProject.Form_insertPS(this);
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

            if (Program.user.UserType == "Начальник ГПС" | Program.user.UserType == "ПТО" | Program.user.UserType == "Руководство")
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

    class ButtonFill
    {
        public void ButtonElSubfill(UserContext db)
        {
            //Создание кнопок подстанций
            foreach (var electricalSubstation in db.Electrical_Substations.Local)
            {
                Button newButton = new Button();
                newButton.Name = "PS_Id_" + Convert.ToString(electricalSubstation.Id);//Остановился здесь 02.11.17
                newButton.BackColor = Color.Silver;
                newButton.Text = electricalSubstation.Name_Electrical_Substation;
                newButton.Size = new Size(140, 50);
                {   //задаю значение Margin
                    var margin = newButton.Margin;
                    margin.All = 10;
                    newButton.Margin = margin;
                }
                newButton.Click += new EventHandler(this.PS_Id_Click);
                flowLayoutPanel_PStancii.Controls.Add(newButton);
            }
        }
    }
}

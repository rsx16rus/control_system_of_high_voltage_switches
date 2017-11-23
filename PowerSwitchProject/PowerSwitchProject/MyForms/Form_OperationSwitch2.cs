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
using System.Windows;

namespace PowerSwitchProject
{
    public partial class Form_OperationSwitch2 : Form
    {
        Table<Switch_model> switchModels;
        Table<Electrical_Substation> electrSubstations;
        Table<Operating_switch> operSwitches;
        //DispetcherFormTools tools = new DispetcherFormTools();
        Operating_switch selected_Oper_switch;
        Switch_model swModel;

        public Form_OperationSwitch2()
        {
            InitializeComponent();
        }
        public Form_OperationSwitch2(Operating_switch selectedSwitch, Switch_model swMod)
        {
            InitializeComponent();

            selected_Oper_switch = selectedSwitch;
            swModel = swMod;

            DataContext db = new DataContext(Program.connectionString);
            switchModels = db.GetTable<Switch_model>();
            electrSubstations = db.GetTable<Electrical_Substation>();
            operSwitches = db.GetTable<Operating_switch>();

            List_of list_of = new List_of();
            string namePS = list_of.Label_Text_SelectedPS((int)selected_Oper_switch.Id_Electrical_Substation);
            comboBox_Location.Text = namePS;
            textBox_DispatchingName.Text = selected_Oper_switch.Dispatching_name;
            //Создание выпадающего списка ПС
            IOrderedQueryable<Electrical_Substation> electricalSubstation_List = list_of.Searched_PS(Program.user);
            var elSubSt = from u in electricalSubstation_List
                          select u.Name_Electrical_Substation;
            string[] user_electricalSubstations = elSubSt.ToArray();
            comboBox_Location.Items.AddRange(user_electricalSubstations);
            
            comboBox_SwitchModel.Text = swModel.Switch_Model_Name;
            var m = from u in switchModels
                         select u.Switch_Model_Name;
            string[] models = m.ToArray();
            comboBox_SwitchModel.Items.AddRange(models);

            textBox_FactoryNumber.Text = selected_Oper_switch.Factory_Number;
            textBox_DateOfManufacture.Text = selected_Oper_switch.Date_of_Manufacture.ToString();
            textBox_DateOfComissioning.Text = Convert.ToString(selected_Oper_switch.Date_of_Comissioning);////выбери метод
            ToolsForOperation_Switch t = new ToolsForOperation_Switch();
            textBox_PoleWearA.Text = 
                Convert.ToString((int)(t.nullDouble_Filter(selected_Oper_switch.Pole_wearA) * 100 / 
                t.nullDouble_Filter(swModel.Electrical_Resource_Limit)));
            textBox_PoleWearB.Text =
                Convert.ToString((int)(t.nullDouble_Filter(selected_Oper_switch.Pole_wearB) * 100 /
                t.nullDouble_Filter(swModel.Electrical_Resource_Limit)));
            textBox_PoleWearC.Text =
                Convert.ToString((int)(t.nullDouble_Filter(selected_Oper_switch.Pole_wearC) * 100 /
                t.nullDouble_Filter(swModel.Electrical_Resource_Limit)));
            textBox_NumberOfKZ.Text = Convert.ToString(selected_Oper_switch.Number_of_Short_Circuits);
            textBox_numberOfMex_Percent.Text = Convert.ToString((int)(t.nullDouble_Filter(selected_Oper_switch.Number_of_mechanical_Shutdowns) * 100 /
                t.nullDouble_Filter(swModel.Mechanical_Resource_Limit)));
            textBox_DateOfMaintenance.Text = Convert.ToString(selected_Oper_switch.Date_of_Maintenance);
            textBox_DateOfOverhaul.Text = Convert.ToString(selected_Oper_switch.Date_of_Overhaul);
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {            
            if (!string.IsNullOrWhiteSpace(textBox_DateOfComissioning.Text))
            {
                selected_Oper_switch.Date_of_Comissioning = DateTime.Parse(textBox_DateOfComissioning.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfMaintenance.Text))
            {
                selected_Oper_switch.Date_of_Maintenance = DateTime.Parse(textBox_DateOfMaintenance.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfManufacture.Text))
            {
                selected_Oper_switch.Date_of_Manufacture = DateTime.Parse(textBox_DateOfManufacture.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfOverhaul.Text))
            {
                selected_Oper_switch.Date_of_Overhaul = DateTime.Parse(textBox_DateOfOverhaul.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DispatchingName.Text))
            {
                selected_Oper_switch.Dispatching_name = textBox_DispatchingName.Text;
            }
            else
            {
                MessageBox.Show("Не указано диспетчерское наименование!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_FactoryNumber.Text))
            {
                selected_Oper_switch.Factory_Number = textBox_FactoryNumber.Text;
            }
            if (comboBox_Location.SelectedItem != null)
            {
                selected_Oper_switch.Id_Electrical_Substation = electrSubstations.First
                    (u => u.Name_Electrical_Substation == comboBox_Location.Text).Id_Electrical_Substation;
            }
            else
            {
                MessageBox.Show("Выберите подстанцию из списка!");
                return;
            }
            if (comboBox_SwitchModel.SelectedItem != null)
            {
                selected_Oper_switch.Id_Switch_model = switchModels.First
                    (u => u.Switch_Model_Name == comboBox_SwitchModel.Text).Id_Switch_Model;
            }
            else
            {
                MessageBox.Show("Выберите модель выключателя из списка!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_numberOfMex_Percent.Text))
            {
                selected_Oper_switch.Number_of_mechanical_Shutdowns = Convert.ToInt32(textBox_numberOfMex_Percent.Text);
            }
            else selected_Oper_switch.Number_of_mechanical_Shutdowns = null;
            if (!string.IsNullOrWhiteSpace(textBox_NumberOfKZ.Text))
            {
                selected_Oper_switch.Number_of_Short_Circuits = Convert.ToInt32(textBox_NumberOfKZ.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearA.Text))
            {
                selected_Oper_switch.Pole_wearA = Convert.ToInt32(textBox_PoleWearA.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearB.Text))
            {
                selected_Oper_switch.Pole_wearB = Convert.ToInt32(textBox_PoleWearB.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearC.Text))
            {
                selected_Oper_switch.Pole_wearC = Convert.ToInt32(textBox_PoleWearC.Text);
            }

            Operating_switch_Update update = new Operating_switch_Update();
            update.operatingSwitchUpdate(selected_Oper_switch);            
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Maintenance_event_Click(object sender, EventArgs e)
        {

        }

        private void button_Overhaul_event_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_OperSw_Click(object sender, EventArgs e)
        {
            Operating_switch_Delete del = new Operating_switch_Delete();
            del.operatingSwitchDelete(selected_Oper_switch.Id_Operating_switch);
            this.Close();
        }
    }
}

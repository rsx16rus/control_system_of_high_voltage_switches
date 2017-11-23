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
    public partial class Form_OperationSwitch_New : Form
    {
        Table<Switch_model> switchModels;
        Table<Electrical_Substation> electrSubstations;
        Table<Operating_switch> operSwitches;
        //DispetcherFormTools tools = new DispetcherFormTools();
        //Operating_switch selected_Oper_switch;

        public Form_OperationSwitch_New()
        {
            InitializeComponent();

            DataContext db = new DataContext(Program.connectionString);
            switchModels = db.GetTable<Switch_model>();
            electrSubstations = db.GetTable<Electrical_Substation>();
            operSwitches = db.GetTable<Operating_switch>();

            List_of list_of = new List_of();
            //Создание выпадающего списка ПС
            IOrderedQueryable<Electrical_Substation> electricalSubstation_List = list_of.Searched_PS(Program.user);
            var elSubSt = from u in electricalSubstation_List
                          select u.Name_Electrical_Substation;
            string[] user_electricalSubstations = elSubSt.ToArray();
            comboBox_Location.Items.AddRange(user_electricalSubstations);

            var m = from u in switchModels
                    select u.Switch_Model_Name;
            string[] models = m.ToArray();
            comboBox_SwitchModel.Items.AddRange(models);

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Operating_switch newOperSw = new Operating_switch();
            if (!string.IsNullOrWhiteSpace(textBox_DateOfComissioning.Text))
            {
                newOperSw.Date_of_Comissioning = DateTime.Parse(textBox_DateOfComissioning.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfMaintenance.Text))
            {
                newOperSw.Date_of_Maintenance = DateTime.Parse(textBox_DateOfMaintenance.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfManufacture.Text))
            {
                newOperSw.Date_of_Manufacture = DateTime.Parse(textBox_DateOfManufacture.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfOverhaul.Text))
            {
                newOperSw.Date_of_Overhaul = DateTime.Parse(textBox_DateOfOverhaul.Text);//!!!Проверка на корректность stringа
            }
            if (!string.IsNullOrWhiteSpace(textBox_DispatchingName.Text))
            {
                newOperSw.Dispatching_name = textBox_DispatchingName.Text;
            }
            else
            {
                MessageBox.Show("Не указано диспетчерское наименование!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_FactoryNumber.Text))
            {
                newOperSw.Factory_Number = textBox_FactoryNumber.Text;
            }
            if (comboBox_Location.SelectedItem != null)
            {
                newOperSw.Id_Electrical_Substation = electrSubstations.First
                    (u => u.Name_Electrical_Substation == comboBox_Location.Text).Id_Electrical_Substation;
            }
            else
            {
                MessageBox.Show("Выберите подстанцию из списка!");
                return;
            }
            if (comboBox_SwitchModel.SelectedItem != null)
            {
                newOperSw.Id_Switch_model = switchModels.First
                    (u => u.Switch_Model_Name == comboBox_SwitchModel.Text).Id_Switch_Model;
            }
            else
            {
                MessageBox.Show("Выберите модель выключателя из списка!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_numberOfMex_Percent.Text))
            {
                newOperSw.Number_of_mechanical_Shutdowns = Convert.ToInt32(textBox_numberOfMex_Percent.Text);
            }
            else newOperSw.Number_of_mechanical_Shutdowns = null;
            if (!string.IsNullOrWhiteSpace(textBox_NumberOfKZ.Text))
            {
                newOperSw.Number_of_Short_Circuits = Convert.ToInt32(textBox_NumberOfKZ.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearA.Text))
            {
                newOperSw.Pole_wearA = Convert.ToInt32(textBox_PoleWearA.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearB.Text))
            {
                newOperSw.Pole_wearB = Convert.ToInt32(textBox_PoleWearB.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearC.Text))
            {
                newOperSw.Pole_wearC = Convert.ToInt32(textBox_PoleWearC.Text);
            }
            Operating_switch_Insert create = new Operating_switch_Insert();
            create.operatingSwitchInsert(newOperSw);
            this.Close();

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form_OperationSwitch : Form
    {
        Table<Switch_model> switchModels;
        Table<Electrical_Substation> electrSubstations;
        Table<Operating_switch> operSwitches;
        //DispetcherFormTools tools = new DispetcherFormTools();
        Operating_switch selected_Oper_switch;
        Switch_model swModel;

        public Form_OperationSwitch()
        {
            InitializeComponent();
        }
        public Form_OperationSwitch(int VV_ID)
        {
            InitializeComponent();

            if (Program.user.UserType == "ПТО" | Program.user.UserType == "Руководство")
            {
                button_Maintenance_event.Enabled = false;
                button_Overhaul_event.Enabled = false;
                button_Correcting_OperSw.Enabled = false;
            }            

            DataContext db = new DataContext(Program.connectionString);
            switchModels = db.GetTable<Switch_model>();
            electrSubstations = db.GetTable<Electrical_Substation>();
            operSwitches = db.GetTable<Operating_switch>();

            DispetcherFormTools tools = new DispetcherFormTools();
            selected_Oper_switch = tools.Selected_Switch(VV_ID, operSwitches);

            List_of list_of = new List_of();
            string namePS = list_of.Label_Text_SelectedPS((int)selected_Oper_switch.Id_Electrical_Substation);
            textBox_Location.Text = namePS;
            textBox_DispatchingName.Text = selected_Oper_switch.Dispatching_name;

            swModel = tools.Selected_Switch_Model(Convert.ToInt32(selected_Oper_switch.Id_Switch_model), switchModels);
            textBox_SwitchModel.Text = swModel.Switch_Model_Name;

            textBox_FactoryNumber.Text = selected_Oper_switch.Factory_Number;
            textBox_DateOfManufacture.Text = selected_Oper_switch.Date_of_Manufacture.ToString();
            textBox_DateOfComissioning.Text = selected_Oper_switch.Date_of_Comissioning.ToString();
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
            textBox_DateOfMaintenance.Text = selected_Oper_switch.Date_of_Maintenance.ToString();
            textBox_DateOfOverhaul.Text = selected_Oper_switch.Date_of_Overhaul.ToString();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
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

        private void button_Correcting_OperSw_Click(object sender, EventArgs e)
        {
            Form_OperationSwitch2 form_correcting = new Form_OperationSwitch2(selected_Oper_switch, swModel);
            form_correcting.Show();
        }
    }
}

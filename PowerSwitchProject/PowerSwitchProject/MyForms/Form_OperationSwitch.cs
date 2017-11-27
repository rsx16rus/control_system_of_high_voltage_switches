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
        User user;
        MyMainWindowForm parentform;
        Operating_switch selected_Oper_switch;
        Switch_model switch_Model;
        UserContext myUserContext = MyLocalData.MyuserContext;


        public Form_OperationSwitch()
        {
            InitializeComponent();
        }
        public Form_OperationSwitch(MyMainWindowForm form, User u, Operating_switch op_sw)
        {
            user = u;
            selected_Oper_switch = op_sw;
            parentform = form;
            InitializeComponent();

            if (user.UserType == "ПТО" | user.UserType == "Руководство")
            {
                button_Maintenance_event.Enabled = false;
                button_Overhaul_event.Enabled = false;
                button_Correcting_OperSw.Enabled = false;
            }
            
            textBox_Location.Text = myUserContext.Electrical_Substations.Local.First(b => b.Id == selected_Oper_switch.Id_Electrical_Substation).Name_Electrical_Substation;
            textBox_DispatchingName.Text = selected_Oper_switch.Dispatching_name;
                        
            switch_Model = myUserContext.Switch_models.Local.First(c => c.Id == selected_Oper_switch.Id_Switch_model);
            textBox_SwitchModel.Text = switch_Model.Switch_Model_Name;

            textBox_FactoryNumber.Text = selected_Oper_switch.Factory_Number;
            textBox_DateOfManufacture.Text = selected_Oper_switch.Date_of_Manufacture.ToString();
            textBox_DateOfComissioning.Text = selected_Oper_switch.Date_of_Commissioning.ToString();            

            //Здесь надо навести порядок с приведением типов, прийти к какому-то единообразию
            textBox_PoleWearA.Text =
                Convert.ToString((int)(Convert.ToDouble(selected_Oper_switch.Pole_wearA) * 100 / Convert.ToDouble(switch_Model.Electrical_Resource_Limit)));//Не вспомню - почему Double????
            textBox_PoleWearB.Text =
                Convert.ToString((int)(Convert.ToDouble(selected_Oper_switch.Pole_wearB) * 100 / Convert.ToDouble(switch_Model.Electrical_Resource_Limit)));//Не вспомню - почему Double????
            textBox_PoleWearC.Text =
                Convert.ToString((int)(Convert.ToDouble(selected_Oper_switch.Pole_wearC) * 100 / Convert.ToDouble(switch_Model.Electrical_Resource_Limit)));//Не вспомню - почему Double????
            textBox_NumberOfKZ.Text = Convert.ToString(selected_Oper_switch.Number_of_Short_Circuits);
            textBox_numberOfMex_Percent.Text = Convert.ToString((int)(Convert.ToDouble(selected_Oper_switch.Number_of_mechanical_Shutdowns) * 100 /
                Convert.ToDouble(switch_Model.Mechanical_Resource_Limit)));//Не вспомню - почему Double????
            textBox_DateOfMaintenance.Text = selected_Oper_switch.Date_of_Maintenance.ToString();
            textBox_DateOfOverhaul.Text = selected_Oper_switch.Date_of_Overhaul.ToString();
        }


        //Эти обработчики не реализованы!!!!!!!!!!
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
            throw new NotImplementedException();
        }

        private void button_Overhaul_event_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_Correcting_OperSw_Click(object sender, EventArgs e)
        {
            Form_Operating_Switch_Edit form_operating_switch_edit = new Form_Operating_Switch_Edit(parentform, selected_Oper_switch, switch_Model);
            form_operating_switch_edit.Show();
        }
    }
}

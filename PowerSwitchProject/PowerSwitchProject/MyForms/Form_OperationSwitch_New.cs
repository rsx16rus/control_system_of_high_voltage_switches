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
    public partial class Form_OperationSwitch_New : Form // Блок готов с некоторыми недочетами!!!!!!!!!!!!!!!!!!!!!
    {
        UserContext myLocalData = MyLocalData.MyuserContext;
        MyMainWindowForm parentform;

        public Form_OperationSwitch_New()
        {
            MessageBox.Show("Программисту: Исправь вызов конструктора формы");
            this.Close();
        }
        public Form_OperationSwitch_New(MyMainWindowForm f)
        {
            parentform = f;
            InitializeComponent();            
                        
            var elSubSt = from u in myLocalData.Electrical_Substations.Local
                          select u.Name_Electrical_Substation;
            string[] user_electricalSubstations = elSubSt.ToArray();
            comboBox_Location.Items.AddRange(user_electricalSubstations);

            var m = from u in myLocalData.Switch_models.Local
                    select u.Switch_Model_Name;
            string[] models = m.ToArray();
            comboBox_SwitchModel.Items.AddRange(models);

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Operating_switch newOperatingSwitch = new Operating_switch();
            if (!string.IsNullOrWhiteSpace(textBox_DateOfCommissioning.Text))
            {
                //!!!Надо проверить на корректность преобразования в Date, т.е. не перепутаны ли месяцы дни
                newOperatingSwitch.Date_of_Commissioning = Convert.ToDateTime(textBox_DateOfCommissioning.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfMaintenance.Text))
            {
                //!!!Надо проверить на корректность преобразования в Date, т.е. не перепутаны ли месяцы дни
                newOperatingSwitch.Date_of_Maintenance = Convert.ToDateTime(textBox_DateOfMaintenance.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfManufacture.Text))
            {
                //!!!Надо проверить на корректность преобразования в Date, т.е. не перепутаны ли месяцы дни
                newOperatingSwitch.Date_of_Manufacture = Convert.ToDateTime(textBox_DateOfManufacture.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_DateOfOverhaul.Text))
            {
                //!!!Надо проверить на корректность преобразования в Date, т.е. не перепутаны ли месяцы дни
                newOperatingSwitch.Date_of_Overhaul = Convert.ToDateTime(textBox_DateOfOverhaul.Text);
            }
            if (!string.IsNullOrWhiteSpace(textBox_DispatchingName.Text))
            {
                newOperatingSwitch.Dispatching_name = textBox_DispatchingName.Text;
            }
            else
            {
                MessageBox.Show("Не указано диспетчерское наименование!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_FactoryNumber.Text))
            {
                newOperatingSwitch.Factory_Number = textBox_FactoryNumber.Text;
            }
            if (comboBox_Location.SelectedItem != null)
            {
                newOperatingSwitch.Id_Electrical_Substation = myLocalData.Electrical_Substations.Local.First
                    (u => u.Name_Electrical_Substation == comboBox_Location.Text).Id; 
            }
            else
            {
                MessageBox.Show("Выберите подстанцию из списка!");
                return;
            }
            if (comboBox_SwitchModel.SelectedItem != null)
            {
                newOperatingSwitch.Id_Switch_model = myLocalData.Switch_models.Local.First
                    (u => u.Switch_Model_Name == comboBox_SwitchModel.Text).Id; //А что если пользователь сам введет значение и такой ВВ не будет найден?
            }
            else
            {
                MessageBox.Show("Выберите модель выключателя из списка!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_numberOfMex_Percent.Text))
            {
                //Неправильно считает. Нужно из процентов переводить в количество?
                newOperatingSwitch.Number_of_mechanical_Shutdowns = Convert.ToInt32(textBox_numberOfMex_Percent.Text);//проверь остаточное или накопленное значение нужно отображать?
            }
            else newOperatingSwitch.Number_of_mechanical_Shutdowns = null;
            if (!string.IsNullOrWhiteSpace(textBox_NumberOfKZ.Text))
            {
                newOperatingSwitch.Number_of_Short_Circuits = Convert.ToInt32(textBox_NumberOfKZ.Text);//Нужна проверка на корректность введенного значения!
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearA.Text))
            {
                newOperatingSwitch.Pole_wearA = Convert.ToInt32(textBox_PoleWearA.Text);//Нужна проверка на корректность введенного значения!
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearB.Text))
            {
                newOperatingSwitch.Pole_wearB = Convert.ToInt32(textBox_PoleWearB.Text);//Нужна проверка на корректность введенного значения!
            }
            if (!string.IsNullOrWhiteSpace(textBox_PoleWearC.Text))
            {
                newOperatingSwitch.Pole_wearC = Convert.ToInt32(textBox_PoleWearC.Text);//Нужна проверка на корректность введенного значения!
            }

            Operating_Switch_Changes ch = new Operating_Switch_Changes();
            ch.Operating_Switch_Insert(newOperatingSwitch);
            parentform.Refresh();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class DispetcherInsertedForm : Form
    {
        Table<Switch_model> switchModels;
        Table<Electrical_Substation> electrSubstations;
        Table<Operating_switch> operSwitches;
        private string phase_name;
        double short_circuit_amperage;
        Operating_switch selected_Oper_switch;
        DispetcherFormTools tools = new DispetcherFormTools();

        public DispetcherInsertedForm()
        {
            InitializeComponent();
        }
        public DispetcherInsertedForm(int VV_ID)
        {
            InitializeComponent();
            DataContext db = new DataContext(Program.connectionString);
            switchModels = db.GetTable<Switch_model>();
            electrSubstations = db.GetTable<Electrical_Substation>();
            operSwitches = db.GetTable<Operating_switch>();

            selected_Oper_switch = tools.Selected_Switch(VV_ID, operSwitches);

            this.Text = selected_Oper_switch.Dispatching_name;
            radioButton_A_Short_Circuit.Click += new EventHandler(this.radioButton_CheckedChanged);
            radioButton_B_Short_Circuit.Click += new EventHandler(this.radioButton_CheckedChanged);
            radioButton_C_Short_Circuit.Click += new EventHandler(this.radioButton_CheckedChanged);
            radioButton_AB_Short_Circuit.Click += new EventHandler(this.radioButton_CheckedChanged);
            radioButton_BC_Short_Circuit.Click += new EventHandler(this.radioButton_CheckedChanged);
            radioButton_AC_Short_Circuit.Click += new EventHandler(this.radioButton_CheckedChanged);
        }
        //только цифры и , в TextBox
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) e.KeyChar = ',';
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        //отслеживание radioButton
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                phase_name = (radioButton.Name).Substring(12, 2);
            }
        }

        private void button_APV_Successfully_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Short_Circuit_Amperage.Text.Length != 0)
                {
                    short_circuit_amperage = double.Parse(textBox_Short_Circuit_Amperage.Text);
                    tools.APV_Successfully(phase_name, short_circuit_amperage, selected_Oper_switch);
                }
                else tools.APV_Successfully(phase_name, 10.0, selected_Oper_switch);//в идеале должен отправляться Max ток КЗ этой модели
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение силы тока!");
            }
        }

        private void button_APV_Disabled_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Short_Circuit_Amperage.Text.Length != 0)
                {
                    short_circuit_amperage = double.Parse(textBox_Short_Circuit_Amperage.Text);
                    tools.APV_Successfully(phase_name, short_circuit_amperage, selected_Oper_switch);
                }
                else tools.APV_Successfully(phase_name, 10.0, selected_Oper_switch);//в идеале должен отправляться Max ток КЗ этой модели
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение силы тока!");
            }
        }

        private void button_APV_Unsuccessfully_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Short_Circuit_Amperage.Text.Length != 0)
                {
                    short_circuit_amperage = double.Parse(textBox_Short_Circuit_Amperage.Text);
                    tools.APV_Unsuccessfully(phase_name, (short_circuit_amperage * 2), selected_Oper_switch);
                }
                else tools.APV_Unsuccessfully(phase_name, 20.0, selected_Oper_switch);//в идеале должен отправляться Max ток КЗ этой модели
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение силы тока!");
            }
        }

        private void button_Planned_Click(object sender, EventArgs e)
        {
            tools.Planned(selected_Oper_switch);
            this.Close();
        }
    }
}

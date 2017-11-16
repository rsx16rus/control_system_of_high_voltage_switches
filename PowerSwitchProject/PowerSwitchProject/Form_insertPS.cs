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
    public partial class Form_insertPS : Form
    {
        UserContext myLocalData = MyLocalData.userContext;
        MyMainWindowForm parentForm;
        public Form_insertPS()
        {
            //InitializeComponent();

            //DataContext db = new DataContext(Program.connectionString);
            //this.reses = db.GetTable<RES>();
            //groupPS = db.GetTable<Group_PS>();

            //var m = from u in this.reses
            //        select u.Name_RES;
            //string[] reses = m.ToArray();
            //comboBox_RES.Items.AddRange(reses);
            //var n = from u in groupPS
            //        select u.Name_Group_PS;
            //string[] groups = n.ToArray();
            //comboBox_GroupPS.Items.AddRange(groups);
            MessageBox.Show("Программисту: Исправь вызов конструктора формы");
        }
        public Form_insertPS(MyMainWindowForm f)
        {
            InitializeComponent();

            try
            {                
                var m = from u in myLocalData.RESes.Local
                        select u.Name_RES;
                string[] reses = m.ToArray();
                comboBox_RES.Items.AddRange(reses);
                var n = from u in myLocalData.Group_PSes.Local
                        select u.Name_Group_PS;
                string[] groups = n.ToArray();
                comboBox_GroupPS.Items.AddRange(groups);
                parentForm = f;
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения выпадающего списка!");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Create_PS_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox_PS_Name.Text;
                string nameGroup = comboBox_GroupPS.Text;
                string nameRES = comboBox_RES.Text;
                Group_PS grpS = groupPS.First(u => u.Name_Group_PS == nameGroup);
                int idGroup = grpS.Id_Group_PS;
                RES r = reses.First(u => u.Name_RES == nameRES);
                int idRes = r.Id_RES;
                Electrical_Substation_Insert ins = new PowerSwitchProject.Electrical_Substation_Insert();

                ins.elSubstationInsert(name, idGroup, idRes);
                parentForm.Refresh();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность заполнения полей");
            }
        }
    }
}

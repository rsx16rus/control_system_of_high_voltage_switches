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
    public partial class Form_insertPS : Form//Блок готов
    {
        UserContext myLocalData = MyLocalData.MyuserContext;
        MyMainWindowForm parentForm;
        
        public Form_insertPS()
        {            
            MessageBox.Show("Программисту: Исправь вызов конструктора формы");
            this.Close();
        }
        public Form_insertPS(MyMainWindowForm f)
        {            
            parentForm = f;
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
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения выпадающего списка!");
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Create_PS_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox_PS_Name.Text;
                string nameGroup = comboBox_GroupPS.Text;
                string nameRES = comboBox_RES.Text;
                Group_PS grpS = myLocalData.Group_PSes.First(u => u.Name_Group_PS == nameGroup);
                int idGroup = grpS.Id;
                RES r = myLocalData.RESes.First(u => u.Name_RES == nameRES);
                int idRes = r.Id;
                
                Electrical_Substation new_electrical_Substation = new Electrical_Substation()// Надо проверить генерируется ли на этой стадии ID?(можно с помощью MessageBox)
                {
                    Name_Electrical_Substation = name,
                    Id_Group_PS = idGroup,
                    Id_RES = idRes
                };
                Electrical_Substation_Changes ins = new Electrical_Substation_Changes();
                ins.Electrical_Substation_Insert(new_electrical_Substation);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace PowerSwitchProject
{
    public partial class IdentityForm : Form
    {
        public IdentityForm()
        {
            InitializeComponent();

            User_Detecting detect = new User_Detecting();
            string[] users = detect.Users();
            comboBoxUsers.Items.AddRange(users);//ввожу элементы выпадающего списка
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedItem != null)
            {
                User_Detecting detect = new User_Detecting();
                User user = detect.User_Detect(comboBoxUsers.SelectedItem.ToString(), textBoxPassword.Text);                
                if (user != null)///такая ли будет проверка в финальной версии?
                {                    
                    Program.user = user;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя из списка");
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Закрытие приложения
            //Environment.Exit(0);            
        }
    }
}

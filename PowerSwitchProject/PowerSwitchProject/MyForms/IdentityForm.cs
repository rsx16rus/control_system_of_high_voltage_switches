using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Linq;
using System.Data.Entity;
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

        private void buttonOk_Click(object sender, EventArgs e)// Для повышения производительности надо убрать повторное обращение к БД
        {
            if (comboBoxUsers.SelectedItem != null)
            {
                User_Detecting detect = new User_Detecting();
                User user = detect.User_Detect(comboBoxUsers.SelectedItem.ToString(), textBoxPassword.Text);
                if (user != null)//в финальной версии такая ли будет проверка?
                {
                    Controller.myUser = user;                                      
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

    class User_Detecting
    {
        public string[] Users()
        {
            using (UserContext db = new UserContext())
            {
                var query = from u in db.Users select u.UserPosition;
                string[] users = query.ToArray();
                return users;
            }
        }
        public User User_Detect(string selected_user_position, string password)
        {
            using (UserContext db = new UserContext())
            {
                //try
                //{
                User user = db.Users.First(u => ((u.UserPosition == selected_user_position) && (u.Password == password)));
                return user;
                //}
                //catch (InvalidOperationException)
                //{
                //    MessageBox.Show("Неверный пароль, проверьте правильность ввода и отсутствие лишних пробелов");
                //}
                //catch (ArgumentNullException)
                //{
                //    MessageBox.Show("Неверный пароль, проверьте правильность ввода и отсутствие лишних пробелов");
                //}

            }
        }
        
    }
}

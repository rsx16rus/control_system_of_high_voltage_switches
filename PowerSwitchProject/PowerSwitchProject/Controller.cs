using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerSwitchProject
{
    public static class Controller
    {
        //Статичный экземпляр UserContext пользователя хранится в классе MyLocalData
        public static User myUser;        
        public static void ApplicRun()
        {
            Application.Run(new IdentityForm());
            if (myUser != null)
            {
                Application.Run(new MyMainWindowForm(myUser));
            }
            else Application.Exit();
        }
    }
}

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
        public static User myUser;
        public static void ApplicRun()
        {
            Application.Run(new IdentityForm());
            if (myUser != null)
            {

            }
            else Application.Exit();
            

        }
    }
}

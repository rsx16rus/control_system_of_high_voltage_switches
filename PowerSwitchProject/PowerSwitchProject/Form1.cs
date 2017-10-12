using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PowerSwitchProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (UserContext db = new UserContext())
            //{
            //    //создадим два объекта user
            //    User dispetcher_ARES = new User { UserPosition = "Диспетчер АРЕС" };
            //    User nachalnikAGPS = new User { UserPosition = "Начальник АГПС" };

            //    db.Users.Add(dispetcher_ARES);
            //    db.Users.Add(nachalnikAGPS);
            //    db.SaveChanges();
            //    MessageBox.Show("Объекты успешно сохранены!");
            //}
        }
    }
}

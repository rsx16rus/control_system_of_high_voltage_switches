using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace PowerSwitchProject.MyModels
{
    interface IModel
    {
        User User { get; set; }
        //DataSet DataSet { get; set; }
        DbSet DbSet { get; set; }
        void MyOperForm();
    }

    class Dispetcher : IModel
    {
        public User User { get; set; }
        public DbSet DbSet { get; set; }
        public void MyOperForm()
        {
            Application.Run(new DispetcherInsertedForm());
        }
    }

    class Group_PS_Chief : IModel
    {
        public User User { get; set; }
        public DbSet DbSet { get; set; }
        public void MyOperForm()
        {
            Application.Run(new Form_OperationSwitch());
        }
    }

    class PTO_User : IModel
    {
        public User User { get; set; }
        public DbSet DbSet { get; set; }

        public void MyOperForm()
        {
            Application.Run(new Form_OperationSwitch());
        }
    }

    class Director : IModel
    {
        public User User { get; set; }
        public DbSet DbSet { get; set; }
        public void MyOperForm()
        {
            Application.Run(new Form_OperationSwitch());
        }
    }
}

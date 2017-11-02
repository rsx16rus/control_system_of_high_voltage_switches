using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PowerSwitchProject
{
    class UserContext : DbContext
    {
        public UserContext() : base("DbConnection")
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Electrical_Substation> Electrical_Substations { get; set; }
        public DbSet<Group_PS> Group_PSes { get; set; }
        public DbSet<RES> RESes { get; set; }
        public DbSet<Switch_model> Switch_models { get; set; }
        public DbSet<Operating_switch> Operating_switches { get; set; }
    }

    class MyLocalData
    {
        UserContext db;
        public UserContext DataFill()
        {
            db = new UserContext();
            db.Electrical_Substations.Load();
            db.Group_PSes.Load();
            db.Operating_switches.Load();
            db.RESes.Load();
            db.Switch_models.Load();
            db.Users.Load();
            //context.Customers.Where(c => c.Age > 25).Load(); Пример загрузки по атрибутам
            return db;
        }
        
    }
}

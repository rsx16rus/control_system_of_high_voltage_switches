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
        public static UserContext userContext { get; set; }//В будущем проработай код на проверку на null, а лучше подумай насчет синглтона

        public void DataFill(User user)// В рабочей версии должны подгружаться только данные пользователя.
        {
            userContext = new UserContext();

            //training
            var r = from Electrical_Substation in userContext.Electrical_Substations
                    join Group_PS in (from g in userContext.Group_PSes
                                      where g.ID_User == user.Id
                                      select g) on
                    Electrical_Substation.Id_Group_PS equals Group_PS.Id
                    select Electrical_Substation;



            userContext.Electrical_Substations.Join(userContext.Group_PSes.Where(u => u.ID_User == user.Id),
                c => c.Id_Group_PS,
                o => o.Id,
                (c, o) => c).Load();//Обязательно проверь правильность работы
            userContext.Group_PSes.Where(u => u.ID_User == user.Id).Load();
            userContext.Operating_switches.Load();
            userContext.RESes.Where(u => u.ID_User == user.Id).Load();
            userContext.Switch_models.Load();//Заходит целиком
            userContext.Users.Load();//Заходит целиком
            //context.Customers.Where(c => c.Age > 25).Load(); Пример загрузки по атрибутам            
        }

    }
}

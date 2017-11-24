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
        //Надо проверить не является UserContext соединенным с БД все время!
        public static UserContext MyuserContext { get; set; }//В будущем проработай код на проверку на заполненность.

        public void DataFill(User user)// Сохраняю в Local только данные пользователя.
        {
            bool flag;
            MyuserContext = new UserContext();
            
            if (user.UserType == "ГПС")
            {
                MyuserContext.Electrical_Substations.Join(MyuserContext.Group_PSes.Where(u => u.ID_User == user.Id),
                c => c.Id_Group_PS,
                o => o.Id,
                (c, o) => c).Load();//Обязательно проверь правильность работы
                flag = true;
            }
            else if (user.UserType == "РЭС")
            {
                MyuserContext.Electrical_Substations.Join(MyuserContext.RESes.Where(u => u.ID_User == user.Id),
                c => c.Id_RES,
                o => o.Id,
                (c, o) => c).Load();//Обязательно проверь правильность работы
                flag = true;
            }
            else
            {
                MyuserContext.Electrical_Substations.Load();//Заходит целиком для остальных ролей
                flag = true;
            }

            MyuserContext.Group_PSes.Load();//Заходит целиком
            MyuserContext.RESes.Load();//Заходит целиком

            if (flag)
            {
                MyuserContext.Operating_switches.Join(MyuserContext.Electrical_Substations.Local,
                b => b.Id_Electrical_Substation,
                g => g.Id,
                (b, g) => b).Load();//Обязательно проверь правильность работы, при распараллеливании возможно Electrical_Substation.Local будет пуст!!!!         
            }               
            MyuserContext.Switch_models.Load();//Заходит целиком
            MyuserContext.Users.Load();//Заходит целиком                      
        }

    }
    //training
    //var r = from Electrical_Substation in userContext.Electrical_Substations
    //        join Group_PS in (from g in userContext.Group_PSes
    //                          where g.ID_User == user.Id
    //                          select g) on
    //        Electrical_Substation.Id_Group_PS equals Group_PS.Id
    //        select Electrical_Substation;
}

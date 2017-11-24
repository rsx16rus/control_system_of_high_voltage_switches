using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace PowerSwitchProject
{
    class Switch_Counting //Поправлен
    {
        public int NumberOfSwitch_ShortCircuits(UserContext db) //IOrderedQueryable<Electrical_Substation> obj это аналог db.Electrical_Substations
        {
            int numOfKZ = 0;
            
            foreach (var electricalSubstation in db.Electrical_Substations.Local)
            {
                var result = from u in db.Operating_switches.Local
                             from y in db.Switch_models.Local
                             where ((u.Id_Switch_model == y.Id) && ((u.Pole_wearA > 0.9 * y.Electrical_Resource_Limit) ||
                             (u.Pole_wearB > 0.9 * y.Electrical_Resource_Limit) || (u.Pole_wearC > 0.9 * y.Electrical_Resource_Limit)))
                             select u;
                var result2 = from u in result
                              where u.Id_Electrical_Substation == electricalSubstation.Id
                              select u;
                numOfKZ += result2.Count();
            }
            return numOfKZ;
        }
        public int NumberOfSwitch_MechanicalShutdowns(UserContext db)
        {
            int numOfMex = 0;
            
            foreach (var electricalSubstation in db.Electrical_Substations.Local)
            {
                var result = from u in db.Operating_switches.Local
                             from y in db.Switch_models.Local
                             where ((u.Id_Switch_model == y.Id) &&
                             (u.Number_of_mechanical_Shutdowns > (0.9 * y.Mechanical_Resource_Limit)))
                             select u;
                var result2 = from u in result
                              where u.Id_Electrical_Substation == electricalSubstation.Id
                              select u;
                numOfMex += result2.Count();
            }
            return numOfMex;
        }
    }

    class List_of_switches
    {
        public IEnumerable<Operating_switch> Create_a_list_of_switches(Electrical_Substation electrical_Substation, int voltage, UserContext db)
        {
            var list = from u in db.Operating_switches.Local
                       where u.Id_Electrical_Substation == electrical_Substation.Id
                       select u;
            return list;
        }
    }

    class Electrical_Substation_Changes
    {
        public void Electrical_Substation_Insert(Electrical_Substation el)
        {
            MyLocalData.MyuserContext.Electrical_Substations.Add(el);
            MyLocalData.MyuserContext.SaveChanges();
        }
        public void Electrical_Substation_Edit()
        {
            throw new NotImplementedException("Допиши метод");
        }
        public void Electrical_Substation_Delete()
        {
            throw new NotImplementedException("Допиши метод");
        }
    }

    class Operating_Switch_Changes
    {
        public void Operating_Switch_Insert(Operating_switch op_sw)
        {
            MyLocalData.MyuserContext.Operating_switches.Add(op_sw);
            MyLocalData.MyuserContext.SaveChanges();
        }
        public void Operating_Switch_Edit()
        {
            throw new NotImplementedException("Допиши метод");
        }
        public void Operating_Switch_Delete()
        {
            throw new NotImplementedException("Допиши метод");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace PowerSwitchProject.MyModels
{
    interface IModel
    {
        User User { get; set; }
        //DataSet Ds { get; set; }
        DbSet DbSet { get; set; }
    }
}

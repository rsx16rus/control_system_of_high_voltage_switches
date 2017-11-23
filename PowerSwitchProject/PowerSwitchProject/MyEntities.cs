using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using System.Data.Linq;
using System.Configuration;
//using System.Data.Linq.Mapping;
using System.Windows.Forms;

namespace PowerSwitchProject
{
    //[Table(Name = "Table_Electrical_Substation")]
    class Electrical_Substation
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        //[Column]
        public string Name_Electrical_Substation { get; set; }
        //[Column]
        public int Id_Group_PS { get; set; }
        //[Column]
        public int Id_RES { get; set; }
    }

    //[Table(Name = "Table_Group_PS")]
    class Group_PS
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        //[Column]
        public string Name_Group_PS { get; set; }

        public int ID_User { get; set; }
    }

    //[Table(Name = "Table_RES")]
    class RES
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        //[Column]
        public string Name_RES { get; set; }

        public int ID_User { get; set; }
    }

    //[Table(Name = "Table_Switch_Model")]
    public class Switch_model
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }  //ид модели ВВ
        //[Column]
        public string Switch_Model_Name { get; set; }  //наименование модели ВВ
        //[Column]
        public int Voltage_Class { get; set; }  //класс напряжения
        //[Column]
        public int Mechanical_Resource_Limit { get; set; }  //предел механического ресурса
        //[Column]
        public int Electrical_Resource_Limit { get; set; }  //предел электрического ресурса
        //[Column]
        public string Factory_Name { get; set; }  //наименование завода
        //[Column]
        public int Nominal_Amperage { get; set; }  //номинальный ток
        //[Column]
        public int Short_Circuit_Amperage { get; set; }  //ток короткого замыкания(ток отключения)      
    }

    //[Table(Name = "Table_Operating_switch")]
    public class Operating_switch
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; } //ид работающего выключателя
        //[Column]
        public string Dispatching_name { get; set; } //диспетчерское наименование
        //[Column]
        public int? Pole_wearA { get; set; }          //износ полюса
        //[Column]
        public int? Pole_wearB { get; set; }          //
        //[Column]
        public int? Pole_wearC { get; set; }          //
        //[Column]
        public int? Number_of_Short_Circuits { get; set; }  //количество КЗ
        //[Column]
        public int? Number_of_mechanical_Shutdowns { get; set; }  //количество мех откл
        //[Column]
        public DateTime? Date_of_Maintenance { get; set; }  //дата ТО
        //[Column]
        public DateTime? Date_of_Overhaul { get; set; }  //дата КР
        //[Column]
        public DateTime? Date_of_Manufacture { get; set; }  //дата производства
        //[Column]
        public DateTime? Date_of_Comissioning { get; set; }  //дата ввода в эксплуатацию
        //[Column]
        public string Factory_Number { get; set; }  //заводской номер
        //[Column]
        public int Id_Switch_model { get; set; }  //ид модели выключателя
        //[Column]
        public int Id_Electrical_Substation { get; set; }  //ид электроподстанции        
    }

    //[Table(Name = "Users")]
    public class User
    {
        //[Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        //[Column]
        public string UserPosition { get; set; }// Наименование конкретной должности
        //[Column]
        public string Password { get; set; }
        //[Column]
        public string UserType { get; set; } //Предусмотрено только "РЭС", "ГПС", "ПТО" и "Руководство"
        //[Column]
        //public int IdSubDivision { get; set; }
    }
    
}

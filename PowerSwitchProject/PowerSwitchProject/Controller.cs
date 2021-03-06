﻿using System;
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
                MyLocalData obj = new MyLocalData();
                obj.DataFill(myUser);
                Application.Run(new MyMainWindowForm(myUser));
            }
            else Application.Exit();
        }
    }
}
//Заметки:
//1)возможно не стоит сохранять в Local только данные конкретного пользователя,
//  ведь если будет передача выключателя на другую ПС относящуюся к другому пользователю, 
//  то могут возникнуть сложности с отменой ошибочной операции(пользователь 
//  после передачи ВВ потеряет его из виду)
using System;
using System.Collections.Generic;
using System.Text;

namespace Home_work.Interface
{
    interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}

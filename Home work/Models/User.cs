using Home_work.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Home_work.Models
{
    class User : IAccount
    {
        public string FullName;
        public string Email;
        private string _password;



        public bool PasswordChecker(string password)
        {
            bool check = true;
            bool tr = false;


            while (check)
            {
                bool lower = false;
                bool up = false;
                bool digit = false;
                if (password.Length >= 8)
                {
                    foreach (char item in password)
                    {

                        if (char.IsLower(item))
                        {
                            lower = true;
                        }

                        else if (char.IsDigit(item))
                        {
                            digit = true;
                        }
                        else if (char.IsUpper(item))
                        {
                            up = true;
                        }
                        if (up == true && digit == true && lower == true)
                        {
                            _password = password;
                            check = false;
                            tr = true;

                        }

                    }

                }
                else
                {
                    Console.WriteLine("Your password should not be less than 8 characters.");
                }

            }

            return tr;

        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}

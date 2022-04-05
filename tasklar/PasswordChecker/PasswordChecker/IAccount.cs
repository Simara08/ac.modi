using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    interface IAccount
    {
        private string password;
        public string Password
        {
            get
            {
                return Password1;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    Password1 = value;
                }
                else
                {
                    Console.WriteLine("Parol teleblere uygun deyil!");
                    return;
                }
            }
        }

        object FullName { get; }
        object Email { get; }
        string Password1 { get; set; }

        public bool PasswordChecker(string pass)
        {
            bool isLong = false;
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;

            if (pass.Length >= 8)
            {
                isLong = true;
            }
            else
            {
                Console.WriteLine("Parol 8 xarakter ve ya daha uzun olmalidir\n");
            }
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i]))
                {
                    isUpper = true;
                }


                if (char.IsLower(pass[i]))
                {
                    isLower = true;
                }


                if (char.IsDigit(pass[i]))
                {
                    isDigit = true;
                }



            }

            if (isLong && isUpper && isLower && isDigit)
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            if (Password != null)
                
            {
                Console.WriteLine($"Full Name : { FullName}\nE-mail: {Email}");
            }
        }
    }
}

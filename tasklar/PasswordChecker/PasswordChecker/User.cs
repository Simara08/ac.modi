using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
    class User : IAccount
    {
        private string _fullname;
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
            }
        }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public object FullName => throw new NotImplementedException();

        object IAccount.Email => throw new NotImplementedException();

        public string Password1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

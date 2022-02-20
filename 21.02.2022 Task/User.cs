using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21._02._2022_Task
{
    internal class User
    {
        public User(string _username, string _password)
        {
            userName = _username;
            password = _password;
        }
        private string Password;
        public bool UserError = false;
        int forcedParametrForTryParse;
        bool isAnyNumber = false;
        bool isAnyLetterUpper = false;
        private string UserName;
        public string userName
        {
            get
            {
                return UserName;
            }

            set
            {
                if (value.Length > 6)
                {
                    UserName = value;
                }
                else
                {
                    UserError = true;
                    Console.WriteLine("Username 6 herfden boyuk olmalidir");
                }
            }
        }

        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i]) && !isAnyLetterUpper)
                    {
                        isAnyLetterUpper = true;
                    }
                    if (int.TryParse(value[i].ToString(), out forcedParametrForTryParse) && !isAnyNumber)
                    {
                        isAnyNumber = true;
                    }

                    if (isAnyLetterUpper && isAnyNumber)
                    {
                        break;
                    }
                }
                if (!isAnyNumber || !isAnyLetterUpper)
                {
                    UserError = true;
                    Console.WriteLine("Passwordda minimum 1 eded olmalidir ve minimum 1 herfi boyuk olmalidir.");
                }
                else
                {
                    Password = value;
                }


            }

        }
        public string getUserInfo()
        {
            return $"Username:{UserName} Password: {Password} ";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._2022_Task
{
    internal class Admin : User
    {
        private bool IsSuperAdmin { get; set; }
        private string Section { get; set; }
        public Admin(bool isSuperAdmin,string section,string username, string password ):base (username,password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section=section;
        }

        public string getAdminInfo()
        {
            return getUserInfo() + $"IsSuperAdmin: {IsSuperAdmin} Section: {Section}";
        }
    }

}

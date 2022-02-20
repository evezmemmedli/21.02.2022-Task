using System;

namespace _21._02._2022_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName;
            string Password;

            while (true)
            {
                Console.WriteLine("Username daxil edin");
                UserName = Console.ReadLine();
                Console.WriteLine("Sifre Daxil Edin");
                Password = Console.ReadLine();
                User user = new User(UserName, Password);
                if (!user.UserError)
                {
                    break;
                }
            }
            Console.WriteLine("Super admindirmi (Y/N) ?");
            //bool IsSuperAdmin = Convert.ToBoolean(Console.ReadLine());
            string SuperAdmin = Console.ReadLine();
            bool IsSuperAdmin = false;
            if (SuperAdmin == "Y")
            {
                IsSuperAdmin = true;
            }
            Console.WriteLine("Bolme daxil edin");
            string Section = Console.ReadLine();
            Admin admin = new Admin(IsSuperAdmin, Section, UserName, Password);
            Console.WriteLine(admin.getAdminInfo());
        }


    }
}

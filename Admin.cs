
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Homeworks
{
    internal class Admin : User
    {
        static int Id;
        string Name;
        string Surname;
        string Password;

        public Admin(string name, string surname, string password) : base(Id + 1, name + surname, password, "Admin")
        {
            Name = name;
            Surname = surname;
            Password = password;
        }


        public void Registration()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Admin Registration");
            Console.WriteLine($" Id: {Id} \n Name: {Name} \n Surname: {Surname} \n Password: {Password}");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public void Login()
        {
            Console.WriteLine("Login page ...");
            Name += Surname;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter please username");
                string username = Console.ReadLine();

                Console.WriteLine("Enter please password");
                string password = Console.ReadLine();

                if (!String.IsNullOrEmpty(username) &&
                    !String.IsNullOrEmpty(password) &&
                    username==Name && 
                    password==Password
                    )
                {
                    Console.WriteLine("Welcome app ... ");
                    break;
                }
            }
        }
    }
}



using System.Drawing;

namespace Homeworks
{
    internal class User
    {
        int Id;
        string UserName;
        string Password;
        string Status;

        public User(int id, string userName, string password, string status)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Status = status;
            Registration();
        }


         void Registration()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("User Registration");
            Console.WriteLine($" Id: { Id} \n Username: {UserName}  \n Password: {Password} \n Status: {Status}");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.ResetColor();
        }
    }

}

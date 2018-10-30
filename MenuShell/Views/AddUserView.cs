using System;
using MenuShell.Domain;
using MenuShell.Services;

namespace MenuShell.Views
{
    class AddUserView : BaseView
    {
        public override void Display()
        {
            while (true)
            {
                base.Display();
                Console.WriteLine("Register new user");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Role: (V)eterinarian, (R)eceptionist or (A)dmin");
                var input = Console.ReadKey(true);
                string role = UserRole(input);
                Console.WriteLine($"Role Chosen = {role}\n");

                Console.WriteLine("Is this Correct, (Y)es (N)o");
                var input2 = Console.ReadKey(true);
                switch (input2.Key)
                {
                    case ConsoleKey.Y:
                        var user = new User(username, password, role);
                        var AddUserService = new AddUserService();
                        AddUserService.AddUserToDatabase(user);
                        MenuController.AdminMenuStart();
                        break;
                    case ConsoleKey.N:
                        continue;
                    default:
                        Console.WriteLine("Wrong input");
                        continue;
                }
                break;
            }
        }

        public AddUserView(string title = "Add User") : base(title)
        {
        }

        public string UserRole(ConsoleKeyInfo input)
        {
            switch (input.Key)
            {
                case ConsoleKey.V:
                {
                    return "veterinarian";
                }
                case ConsoleKey.R:
                {
                    return "receptionist";
                }
                case ConsoleKey.A:
                {
                    return "administrator";
                }
                default:
                    Console.WriteLine("Wrong input");
                    Display();
                    return "";
            }
        }
    }
}

using System;
using MenuShell.Domain;
using MenuShell.Services;

namespace MenuShell.Views
{
    class LoginView : BaseView
    {
        public override void Display()
        {
            while (true)
            {
                base.Display();
                Console.WriteLine("Please Login\n");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Is this correct? (Y)es (N)");
                var input = Console.ReadKey();

                switch (input.Key)
                {
                    case ConsoleKey.Y:
                    {
                        var authenticationService = new AuthenticationService();
                        var user = authenticationService.Authenticate(username, password);

                        if (user != null && user.Role == "administrator")
                        {
                            MenuController.AdminMenuStart();
                        }
                        else if (user != null && user.Role == "receptionist")
                        {
                            MenuController.ReceptionistMenuStart();
                        }
                        else if (user == null)
                        {
                            continue;
                        }

                        break;
                    }
                    case ConsoleKey.N:
                        continue;
                    default:
                        Console.WriteLine("invalid selection");
                        break;
                }

                break;
            }
        }

        public LoginView(string title = "Login") : base(title)
        {
        }
    }
}

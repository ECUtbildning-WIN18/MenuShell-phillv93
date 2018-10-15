using System;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class AdministratorMainView : BaseView
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("AdminView\n");
            Console.WriteLine("(1) Add User");
            Console.WriteLine("(2) Delete User");
            Console.WriteLine("(3) Log out");
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    MenuController.AdminAddUserStart();
                    break;
                case ConsoleKey.D2:
                    MenuController.AdminDeleteUserStart();
                    break;
                case ConsoleKey.D3:
                    MenuController.Start();
                    break;
            }
        }

        public AdministratorMainView(string title = "Administrator Menu") : base(title)
        {
        }
    }
}

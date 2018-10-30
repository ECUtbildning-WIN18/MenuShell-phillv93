using System;
using System.Threading;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class DeleteUserView : BaseView
    {
        public DeleteUserView(string title = "Delete User") : base(title)
        {
        }

        public override void Display()
        {
            while (true)
            {
                base.Display();
                Console.WriteLine("Delete User");
                int i = 1;
                foreach (var user in Program.userCollection)
                {
                    Console.WriteLine($"({i}) {user.UserName}, {user.Role}");
                    i += 1;
                }
                
                var input = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nDo you want to Delete user: {Program.userCollection[input - 1].UserName}");
                Console.Write("(Y)es, (N)o");
                var choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("\nDeleting User...");
                        Thread.Sleep(1000);
                        Program.userCollection.RemoveAt(input - 1);
                        MenuController.AdminMenuStart();
                        break;

                    case ConsoleKey.N:
                        MenuController.AdminMenuStart();
                        break;
                }
                break;
            }
        }
    }
}

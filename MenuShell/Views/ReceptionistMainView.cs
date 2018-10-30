using System;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class ReceptionistMainView : BaseView
    {
        public override void Display()
        {
            while (true)
            {
                base.Display();
                Console.WriteLine("HEJ RECEPTIONIST");
                Console.WriteLine("(E)xit");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.E)
                {
                    MenuController.Start();
                }
                else
                {
                    Console.WriteLine("wrong input dummy");
                    continue;
                }
                break;
            }
        }

        public ReceptionistMainView(string title = "Receptionist Menu") : base(title)
        {
        }
    }
}

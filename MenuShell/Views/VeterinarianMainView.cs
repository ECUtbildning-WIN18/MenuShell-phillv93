using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuShell.Domain;

namespace MenuShell.Views
{
    class VeterinarianMainView : BaseView
    {
        public override void Display()
        {
            while (true)
            {
                base.Display();
                Console.WriteLine("HEJ Veterinarian");
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

        public VeterinarianMainView(string title = "Veterinarian Menu") : base(title)
        {
        }
    }
}

using System.Collections.Generic;
using MenuShell.Domain;

namespace MenuShell
{
    class Program
    {
        internal static List<User> userCollection;

        static void Main(string[] args)
        {
            var users = new UserCollection();
            userCollection = users.GetUsers();
            
            MenuController.Start();
        }
    }
}

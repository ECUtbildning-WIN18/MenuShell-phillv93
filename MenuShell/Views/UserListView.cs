using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MenuShell.Domain;
using MenuShell.Services;

namespace MenuShell.Views
{
    class UserListView 
    {
        public List<User> FoundUsers { get; } = new List<User>();
        public void Display(string username)
        {
            SearchUsers(username);
            Console.WriteLine("Usernames\n");
            if (FoundUsers.Count != 0)
            {
                foreach (var user in FoundUsers)
                {
                    Console.WriteLine($"{user.UserName}");
                }
                Console.WriteLine("\n(D)elete");
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.D)
                {
                    Console.Write("Enter Username for deletion: ");
                    string deleteUsername = Console.ReadLine();
                    DeleteUser(deleteUsername);
                    Console.WriteLine("User Deleted. Returning to Main menu");
                    Thread.Sleep(2000);
                    MenuController.AdminMenuStart();
                }
                else
                {
                    Console.WriteLine("Returning to previous menu");
                    MenuController.AdminMenuStart();
                }
            }

            else
            {
                Console.WriteLine($"Cant find user matching {{{username}}}. Returning to previous");
                Thread.Sleep(2000);
                MenuController.UserSearchViewStart();
            }
        }

        public void SearchUsers(string username)
        {
            foreach (var user in Program.userCollection)
            {
                if (user.UserName.Contains(username))
                {
                    FoundUsers.Add(user);
                }
            }
        }

        public void DeleteUser(string username)
        {
            var deleteUsername = FoundUsers.SingleOrDefault(r => r.UserName == username);
            if (deleteUsername != null)
            {
                var deleteUserService = new DeleteUserService();
                deleteUserService.DeleteUserFromDatabase(deleteUsername);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("wrong input");
                Thread.Sleep(1500);
                MenuController.UserSearchViewStart();
            }
        }
    }
}

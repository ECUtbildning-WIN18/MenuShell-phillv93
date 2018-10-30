using System;

namespace MenuShell.Views
{
    class UserSearchView : BaseView
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Search by username");
            string username = Console.ReadLine();
            var userListView = new UserListView();
            userListView.Display(username);
        }

        public UserSearchView(string title = "Search User") : base(title)
        {
        }
    }
}

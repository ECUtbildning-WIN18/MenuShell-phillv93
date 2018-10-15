﻿using MenuShell.Views;

namespace MenuShell.Domain
{
    class MenuController
    {
        //private static bool _loggedIn;
            
        public static void Start()
        {
            var loginView = new LoginView();
            loginView.Display();
        }

        public static void AdminMenuStart()
        {
            var administratorMainView = new AdministratorMainView();
            administratorMainView.Display();
            
        }

        public static void AdminAddUserStart()
        {
            var addUserView = new AddUserView();
            addUserView.Display();
        }
        public static void AdminDeleteUserStart()
        {
            var deleteUserView= new DeleteUserView();
            deleteUserView.Display();
        }

        public static void ReceptionistMenuStart()
        {
            var receptionistMainView = new ReceptionistMainView();
            receptionistMainView.Display();
        }
    }
}

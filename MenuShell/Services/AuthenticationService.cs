using System.Collections.Generic;
using System.Linq;
using MenuShell.Domain;

namespace MenuShell.Services
{
    class AuthenticationService : IAuthenticationService
    {
        public List<User> Users { get; set; }
        public AuthenticationService()
        {
            Users = Program.userCollection;
        }

        public User Authenticate(string username, string password)
        {
            //User user = 
            return Users.FirstOrDefault(x => x.UserName == username && x.PassWord == password); 
        }
    }
}

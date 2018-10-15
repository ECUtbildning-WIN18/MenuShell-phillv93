using System.Collections.Generic;

namespace MenuShell.Domain
{
    class UserCollection
    {
        public List<User> Users = new List<User>()
        {
            new User("admin", "secret", "administrator")
        };
        
        public List<User> GetUsers()
        {
            return Users;
        }
    }
}   

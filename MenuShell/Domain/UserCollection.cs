using System.Collections.Generic;

namespace MenuShell.Domain
{
    class UserCollection
    {
        public List<User> Users = new List<User>
        {
            new User("admin", "password", "administrator") ,
            new User("Jane", "password", "veterinarian"),
            new User("Jake", "password", "veterinarian"),
            new User("Jim", "password", "receptionist") 
        };
        
        public List<User> GetUsers()
        {
            return Users;
        }
    }
}   

using System.Collections.Generic;
using System.Data.SqlClient;

namespace MenuShell.Domain
{
    class UserCollection
    {
        public List<User> GetUsers()
        {
            List<User> result = new List<User>();
            
            string sqlQuery = "SELECT * FROM [User]";
            
            var connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                
                var reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string userName = reader["UserName"].ToString();
                        string password = reader["Password"].ToString();
                        string role = reader["UserRole"].ToString();
                        var user = new User(userName, password, role);
                        result.Add(user);
                    }
                }
                return result;
            }
        }
    }
}   

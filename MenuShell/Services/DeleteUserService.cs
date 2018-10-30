using System.Data.SqlClient;
using MenuShell.Domain;

namespace MenuShell.Services
{
    class DeleteUserService
    {
        public void DeleteUserFromDatabase(User user)
        {
            string sqlQuery = $"DELETE FROM [User] WHERE UserName = '{user.UserName}' AND UserRole = '{user.Role}'";
            var connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                }
                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
            var userCollection = new UserCollection();
            Program.userCollection = userCollection.GetUsers();
        }
       
    }
}

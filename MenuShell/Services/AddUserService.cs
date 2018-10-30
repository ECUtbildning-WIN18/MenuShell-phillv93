using System.Data.SqlClient;
using MenuShell.Domain;

namespace MenuShell.Services
{
    class AddUserService
    {
        public void AddUserToDatabase(User user)
        {
            string createQuery =
                $"INSERT INTO [User] (UserName, Password , UserRole) Values('{user.UserName}', '{user.PassWord}', '{user.Role}')";
            
            var connectionString = "Data Source=(local);Initial Catalog=MenuShell;Integrated Security=true";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                var command = new SqlCommand(createQuery, connection);
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

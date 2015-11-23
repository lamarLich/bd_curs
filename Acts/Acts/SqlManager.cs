using System.Data.SqlClient;


namespace Acts
{
    public static class SqlManager
    {
        private static SqlConnection _connection;
        public static void Connect(string username, string password)
        {
            string connectionString = $"Server=localhost; Database=[Акты]; User Id={username}; password={password}";
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public static void CloseConnection()
        {
            _connection.Close();
        }
        public static void UpdateQuery(string query)
        {
            var command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
        }

        public static Roles GetCurrentRole()
        {
            var command = new SqlCommand("declare @user sysname set @user = user exec sp_helpuser @user");
            var reader = command.ExecuteReader();
            reader.Read();
            return (Roles)reader["RoleName"];
        }
    }
}


public enum Roles
{
    Admin, User1, User2
}

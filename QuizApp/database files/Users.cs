using System.Data.SqlClient;
using System.Data;

namespace QuizApp.database_files
{
    class Users
    {

        SqlConnection con;
        public Users()
        {
            con = Connection.GetConnection();
        }
        public bool ValidateUsername(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Username", username);

            int userCount = (int)cmd.ExecuteScalar();

            return userCount > 0;
        }
        public void AddUsers(string username, string password)
        {
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
        }

        public bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Role = 'User'";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password); 

            int userCount = (int)cmd.ExecuteScalar();

            return userCount > 0;
        }
        public bool ValidateAdmin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password AND Role = 'Admin'";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            int userCount = (int)cmd.ExecuteScalar();

            return userCount > 0;
        }
        public DataSet GetUsers(string panel)
        {
            DataSet ds = new DataSet();
            if (panel.Equals("Admin"))
            {
                string query = "select UserId, Username, Password from Users where Role='User'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ds);
            }
            return ds;
        }
    }
}

using MySql.Data.MySqlClient;

namespace ProjCSharp.Models
{
    internal class Connect
    {
        string ConnectionString;
        
        public Connect (string _connectionString)
        {
            ConnectionString = _connectionString;
        }

        public bool OpenConnection()
        {
            MySqlConnection conn = new (ConnectionString);

            if (conn == null)
            {
                conn.Open();
                return true;
            }
            else
            {
                return false;
            }
        }











    }
}

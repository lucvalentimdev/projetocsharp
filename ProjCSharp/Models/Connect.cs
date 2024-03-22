using MySql.Data.MySqlClient;

namespace SalSystem.Models
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

            try
            {
               conn.Open();
               return true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }
        }
    }
}

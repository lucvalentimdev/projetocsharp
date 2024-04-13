using MySql.Data.MySqlClient;

namespace SalSystem.Services
{
    internal class TestConnect()
    {
        readonly private string StringConnectionTest = "server=localhost;user=root;pwd=;database=test;";
        public bool ConnectTest()
        {
            try
            {
                MySqlConnection _conn = new(StringConnectionTest);
                _conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}

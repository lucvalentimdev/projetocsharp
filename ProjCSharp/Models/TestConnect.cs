using MySql.Data.MySqlClient;

namespace SalSystem.Models
{
    internal class TestConnect (string StringConnectionTest)
    {
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

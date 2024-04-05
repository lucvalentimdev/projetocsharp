using MySql.Data.MySqlClient;
using System.Windows.Forms.Design;

namespace SalSystem.Controllers
{
    internal class ProcessaLogin(string ConnectionString)
    {
        public bool ValidaLogin(string username, string password)
        {
            MySqlConnection _conn = new(ConnectionString);
            bool _valido = false;
            try
            {
                _conn.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados!" + E.Message);
                throw;
            }

            MySqlCommand _cmd = new("SELECT * FROM usuarios_sistema WHERE nome=@username AND senha=@password", _conn);
            _cmd.Parameters.AddWithValue("@username", username);
            _cmd.Parameters.AddWithValue("@password", password);

            try
            {
                MySqlDataReader _rd = _cmd.ExecuteReader();
                if (_rd.Read())
                    _valido = true;
            }
            catch (MySqlException)
            {
                throw;
            }

            return _valido;
        }
    }
}


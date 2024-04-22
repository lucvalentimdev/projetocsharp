using MySql.Data.MySqlClient;

namespace SalSystem.Services;

internal class ProcessLogin()
{
    readonly private string ConnectionString = "server=localhost;user=root;pwd=;database=test;";

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

        MySqlCommand _cmd = new(" SELECT * FROM usuario"    +
                                " WHERE usuario=@username AND senha=@password", _conn);
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
        finally
        {
            _conn.Close();
        }

        return _valido;
        
    }
}


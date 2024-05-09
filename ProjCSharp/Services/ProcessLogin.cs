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
        catch (MySqlException E)
        {
            Utilities.MessageError("Erro ao conectar com o banco de dados! Log: \r\n" + E.Message);
            throw;
        }

        try
        {
            MySqlCommand _cmd = new(" SELECT * FROM usuario"    +
                                    " WHERE usuario=@username AND senha=@password", _conn);
            _cmd.Parameters.AddWithValue("@username", username);
            _cmd.Parameters.AddWithValue("@password", password);

       
            MySqlDataReader _rd = _cmd.ExecuteReader();
            if (_rd.Read())
                _valido = true;
        }
        catch (MySqlException E)
        {
            Utilities.MessageError("Erro ao validar o login do usuário! Log: \r\n");
            throw;
        }
        finally
        {
            _conn.Close();
        }

        return _valido;
        
    }
}


using MySql.Data.MySqlClient;
using System;

namespace SalSystem.Models
{
    internal class Login // Classe responsável po conexão geral //
    {
        string ConnectionString;

        public bool ValidaLogin(string username, string password)
        {
            bool _valido = false;

            using (MySqlConnection _conn = new(ConnectionString))
            {
                _conn.Open();

                string query = "SELECT * FROM usuarios_sistemas WHERE nome=@username AND senha=@password";

                using (MySqlCommand command = new(query, _conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        using (MySqlDataReader dataReader = command.ExecuteReader())
                        {
                            if (dataReader.Read())
                            {
                                _valido = true;
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Tratar exceção, logar erro, etc.//
                        Console.WriteLine("Erro ao validar login: " + ex.Message);
                    }
                }
            }

            return _valido;
        }
    }
}


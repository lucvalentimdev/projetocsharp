﻿using MySql.Data.MySqlClient;

namespace SalSystem.Models
{
    internal class ProcessaLogin (string ConnectionString)
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
            catch (MySqlException E)
            {
                Console.WriteLine("Erro ao validar login: " + E.Message);
                throw;
            }
           
            return _valido;
        }
    }
}


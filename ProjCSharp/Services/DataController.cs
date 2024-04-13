using MySql.Data.MySqlClient;

namespace SalSystem.Services
{
    internal class DataController()
    {
        readonly MySqlConnection _conn = new("server=localhost;user=root;pwd=;database=test;");

		private void Connect()
		{
			if (_conn.State != System.Data.ConnectionState.Open)
			_conn.Open();
		}
		
		private void Disconnect()
		{
			if (_conn.State == System.Data.ConnectionState.Open)
				_conn.Close();
		}

//======================== QUERYS DE INSERT / SELECT / UPDATE =====================================================================================================//
        public string QueryInsert(string _sqlString)		//----- Query de insert através de um Insert SQL -----//
        {
            try
			{
				if (_conn != null)
				{
					Connect();
					MySqlCommand _cmd = new(_sqlString, _conn);
					_cmd.ExecuteNonQuery();

					return "Salvo com sucesso!";
				}
				else
					return "Erro no processo de conexão com banco de dados!";
				
			}
			catch (Exception E)
			{
				return "Erro ao salvar! Log: "+ E.Message;
			}
			finally
			{
                Disconnect();
            }
        } 
		
		public static Boolean BooleanQuery(string _sqlString)  //----- Query apenas True ou False através de Select -----//
        {
			if (1>1)
				return true;
			else
				return false;
		}
    }
}



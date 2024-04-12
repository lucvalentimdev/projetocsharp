using MySql.Data.MySqlClient;

namespace SalSystem.Services
{
    internal class DataController()
    {
        readonly MySqlConnection _conn = new("server=localhost;user=root;pwd=;database=test;");

		private void Connect()
		{
			if (_conn == null)
                _conn.Open();
		}
		
		private void Disconnect()
		{
			if (_conn != null)
				_conn.Close();
		}

//======================== QUERYS DE INSERT / SELECT / UPDATE =====================================================================================================//
        public Boolean QueryInsert(string _sqlString)		// Query de insert através de um Insert SQL //
        {
            try
			{
				Connect();
                MySqlCommand _cmd = new(_sqlString, _conn);
                _cmd.ExecuteNonQuery();

                return true;
			}
			catch (Exception )
			{
				return false;
			}
			finally
			{
                Disconnect();
            }
        } 
		
		public static Boolean BooleanQuery(string _sqlString)  // Query apenas True ou False através de Select //
		{
			if (1>1)
				return true;
			else
				return false;
		}
    }
}



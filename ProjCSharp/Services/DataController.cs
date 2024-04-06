using MySql.Data.MySqlClient;
using System.Linq.Expressions;


namespace SalSystem.Services
{
	internal class DataController
	{
        public static Boolean QueryInsert(string _stringConnection, string _sqlString)
        {
            MySqlConnection _conn = new(_stringConnection);

            try
			{
				_conn.Open();
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
				_conn?.Close();
			}
        }     
    }
}



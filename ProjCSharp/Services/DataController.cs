using MySql.Data.MySqlClient;

namespace SalSystem.Services;

internal class DataController()
{
	readonly MySqlConnection conn = new("server=localhost;user=root;pwd=;database=test;");

	private void Connect()
	{
		if (conn.State != System.Data.ConnectionState.Open)
		conn.Open();
	}
	
	private void Disconnect()
	{
		if (conn.State == System.Data.ConnectionState.Open)
			conn.Close();
	}

//======================== QUERYS DE INSERT / SELECT / UPDATE =====================================================================================================//
    public string QryInsertCliente(string _nome, string _cpf, string _telefone, string _cidade, string _cep, string _uf,string _logradouro,  string _nuResidencia )	
	{																									
            try
		{
			string _sqlString = "INSERT INTO cliente (Nome, CPF, telefone, cidade, cep, uf, logradouro, numero_residencia) " +
		   "VALUES (@nome, @cpf, @telefone, @cidade, @cep, @uf, @logradouro, @numResidencia)";

                if (conn != null)
			{
				Connect();
				MySqlCommand _cmd = new(_sqlString, conn);                                             //*** Query 01 --> Insert de Clientes ***//
                    _cmd.Parameters.AddWithValue("@nome", _nome);
                    _cmd.Parameters.AddWithValue("cpf", _cpf);
                    _cmd.Parameters.AddWithValue("@telefone", _telefone);
                    _cmd.Parameters.AddWithValue("@cidade", _cidade);
                    _cmd.Parameters.AddWithValue("@cep", _cep);
                    _cmd.Parameters.AddWithValue("@logradouro", _logradouro);
                    _cmd.Parameters.AddWithValue("@uf", _uf);
                    _cmd.Parameters.AddWithValue("@numResidencia", _nuResidencia);
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



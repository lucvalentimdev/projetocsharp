using MySql.Data.MySqlClient;
using SalSystem.Models;

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

	//=====================================================================================================================================================================//
    //====================== QUERYS GERAIS -> INSERT / SELECT / UPDATE ====================================================================================================//
	//=====================================================================================================================================================================//
    
	//******* Query 01 --> Insert de Clientes *******//
    public string QryInsertCliente(string _nome, string _cpf, string _telefone, string _cidade, string _cep, string _uf,string _logradouro,  string _nuResidencia )	
	{																									
        try
		{
			string _sqlString = "INSERT INTO cliente (Nome, CPF, telefone, cidade, cep, uf, logradouro, numero_residencia) " +
		   "VALUES (@nome, @cpf, @telefone, @cidade, @cep, @uf, @logradouro, @numResidencia)";

            if (conn != null)
			{
				Connect();
				MySqlCommand _cmd = new(_sqlString, conn);                                             
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
		catch (MySqlException E)
		{
			return "Erro ao salvar! Log: "+ E.Message;
		}
		finally
		{
			Disconnect();
        }
    }

    //*** Query 02 --> Apenas True ou False através de Select ***//
    /*public static Boolean BooleanQuery(string _sqlString)  
        {
		if (1>1)
			return true;
		else
			return false;
	} */

    //******* Query 03 --> Insert PRODUTOS *******//
    public string QueryInsertPruduto(string _nome, string _marca, string _categoria, int _volumeEmMl, double _preco, string _descricao, string _publicoAlvo, int _qntEntradaIni, DateTime _dataCadastro, string _img)
	{
		try
		{
			if (conn != null)
			{
				Connect();
			   string _sqlScript = " INSERT INTO Produtos (Nome, Marca, Categoria, VolumeEmMl, Preco, Descricao, PublicoAlvo, QntEntradaInicial, DataCadastro, Imagem)\r\n						VALUES (@Nome, @Marca, @Categoria, @VolumeEmMl, @Preco, @Descricao, @PublicoAlvo, @QntEntradaInicial, @DataCadastro, @Imagem);";
				MySqlCommand _cmd = new(_sqlScript, conn);
				_cmd.Parameters.AddWithValue("@Nome", _nome);
				_cmd.Parameters.AddWithValue("@Marca", _marca);
				_cmd.Parameters.AddWithValue("@Categoria", _categoria);
				_cmd.Parameters.AddWithValue("@VolumeEmMl", _volumeEmMl);
				_cmd.Parameters.AddWithValue("@Preco", _preco);
				_cmd.Parameters.AddWithValue("@Descricao", _descricao);
				_cmd.Parameters.AddWithValue("@PublicoAlvo", _publicoAlvo);
				_cmd.Parameters.AddWithValue("@QntEntradaInicial", _qntEntradaIni);
				_cmd.Parameters.AddWithValue("@DataCadastro", _dataCadastro);
				_cmd.Parameters.AddWithValue("@Imagem", _img);
				_cmd.ExecuteNonQuery();
	
				return "Salvo com sucesso!";
            }
            else
            return "Erro no processo de conexão com banco de dados!";
		}
		catch (MySqlException E)
		{
			return "Erro ao salvar! Log: "+ E.Message;
		}
		finally
		{
			Disconnect();
        }
	}

    //******* Query 04 --> Encontra para apresentar o prox. Cód Produto *******//
    public string QueryBuscaIDProd()
	{
		string _sqlScript = "SELECT MAX((id)+1) FROM produtos";
		try
		{
            Connect();
            if (conn != null)
            {
                MySqlCommand _cmd = new(_sqlScript, conn);
				object _result = _cmd.ExecuteScalar();			// <-- ExecuteScalar para retornar apenas um valor//

				if (_result != null)
					return _result.ToString();
				else
					return "";
            }
            else
                return "";

        }
		catch (MySqlException)
		{
			throw;
		}
		finally
		{
			Disconnect();
		}
			
	
	}

    //******* Query 05 --> Encontra o cliente buscando pelo CPF *******//
	public string GetCliente(string _cpf)
	{
		string _stringSql = "SELECT nome FROM cliente WHERE cpf = @cpf ";
		
		try
		{
            Connect();
			if (conn != null)
			{
				MySqlCommand _cmd = new(_stringSql, conn);
				_cmd.Parameters.AddWithValue("@cpf", _cpf);
				object _result = _cmd.ExecuteScalar();

				if (_result != null)
					return _result.ToString();
				else
					return "Não foi encontrado nenhum cliente nessa consulta!";
			}
			else
				return "Erro ao conectar ao banco de dados!";
        }
		catch (MySqlException)
		{
            return "Erro ao executar a consulta";
            throw;
		}
		finally
		{
			Disconnect();
		}
	}


	public List <Produto> GetProduto(string _filtroSql)
	{
		List<Produto> _list = new();
		string _sqlScript = "SELECT * FROM produtos " +
							"WHERE nome LIKE CONCAT('%', @filtro, '%') OR cod LIKE CONCAT('%', @filtro, '%');";

		try
		{
			Connect();

			if (conn != null)
			{
				MySqlCommand _cmd = new(_sqlScript, conn);
				_cmd.Parameters.AddWithValue("@filtro", _filtroSql);
				MySqlDataReader _dr = _cmd.ExecuteReader();

				while (_dr.Read())
				{
					{
						int _idProd = Convert.ToInt32(_dr["id"]);
						string _nome = _dr["nome"].ToString();
						string _marca = _dr["marca"].ToString();
						string _categoria = _dr["categoria"].ToString();
						int _volumeEmMl = Convert.ToInt32(_dr["volumeEmMl"]);
						double _preco = Convert.ToDouble(_dr["preco"]);
						string _descricao = _dr["descricao"].ToString();
						string _publicoAlvo = _dr["publicoAlvo"].ToString();
						int _qntEntradaIni = Convert.ToInt32(_dr["qntEntradaInicial"]);
						DateTime _dataCadastro = Convert.ToDateTime(_dr["dataCadastro"]);
						string _img = _dr["imagem"].ToString();

						Produto _produto = new(_idProd, _nome, _marca, _categoria, _volumeEmMl, _preco, _descricao, _publicoAlvo, _qntEntradaIni, _dataCadastro, _img);
					};
				}

				return _list;
			}
			else
				return _list;

		}
		catch (MySqlException)
		{
			return _list;
			throw;
		}
		finally
		{
			Disconnect();
		}
		
	} 



}



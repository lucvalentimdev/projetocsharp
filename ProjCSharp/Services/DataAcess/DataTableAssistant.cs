using MySql.Data.MySqlClient;
using System.Data;

namespace SalSystem.Services.DataAcess;

internal class DataTableAssistant
{
    public static DataTable ProcessData(MySqlDataReader reader)
    {
        DataTable dataTable = new();
        dataTable.Load(reader);
        return dataTable;
    }


}

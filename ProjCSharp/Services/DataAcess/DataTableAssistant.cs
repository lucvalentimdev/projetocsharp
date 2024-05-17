using System.Data;

namespace SalSystem.Services.DataAcess;

internal class DataTableAssistant
{
    public static DataTable ProcessData(DataTable _table)
    {
		try
		{
            return _table;
        }
		catch (Exception)
		{
			throw;
		}
	
    }


}

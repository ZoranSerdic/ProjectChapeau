using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class TableService
    {
        TableDAO tableDAO;
        public TableService()
        {
            tableDAO = new TableDAO();
        }
        public Table GetTableById(int tableId)
        {
            return tableDAO.GetTableById(tableId);
        }
        public List<Table> GetAllTables()
        {
            return tableDAO.GetAllTables();
        }
        public void UpdateTableStatus(int tableId, TableStatus newStatus)
        {
            Table table = tableDAO.GetTableById(tableId);

            if (table != null)
            {
                 table.Status = newStatus;
                 tableDAO.UpdateTableStatus(table);
            }
        }
    }
}

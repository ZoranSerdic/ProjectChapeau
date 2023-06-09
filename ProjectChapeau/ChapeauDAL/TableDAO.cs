using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class TableDAO : BaseDAO
    {
        public Table GetTableById(int tableId)
        {
            string query = @"SELECT tableId, status 
                                FROM [Table]
                                WHERE tableId = @TableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TableId", tableId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                Table table = ReadTable(dataRow);
                return table;
            }
            throw new Exception($"Table with the {tableId} id was not found!");
    }

        private Table ReadTable(DataRow dataRow)
        {
            Table table = new Table
            {
                TableId = (int)dataRow["tableId"],
                Status = (TableStatus)Enum.Parse(typeof(TableStatus), dataRow["status"].ToString(), ignoreCase: true)
            };
            return table;
        }
    }
}

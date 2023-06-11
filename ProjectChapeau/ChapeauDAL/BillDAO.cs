using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChapeauDAL
{
    public class BillDAO : BaseDAO
    {
        public List<Bill> GetAllBills()
        {
            //gathering all bills from the table
            string query = "SELECT billId, tableId, totalAmount, totalTip, comment, [date] FROM bill;";
            return ReadTables(ExecuteSelectQuery(query));
        }
        private List<Bill> ReadTables(DataTable dataTable)
        {
            //this methods gets all the bills in a list from the database 
            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    //Table = new Table(),
                    BillId = (int)dr["billId"],
                    //Table.TableId = (int)dr["tableId"],
                    TotalAmount = (decimal)dr["totalAmount"],
                    TotalTip = (decimal)dr["totalTip"],
                    Date = (DateTime)dr["date"],
                    Comment = dr["comment"].ToString(),
                };
                bills.Add(bill);
            }
            return bills;
        }
    }
}

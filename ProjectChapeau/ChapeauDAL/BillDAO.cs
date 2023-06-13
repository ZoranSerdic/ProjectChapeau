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
            DataTable dataTable = ExecuteSelectQuery(query);

            List<Bill> bills = new List<Bill>();

            foreach (DataRow dr in dataTable.Rows)
            {
                bills.Add(ReadBill(dr));
            }

            return bills;
        }
        public void InsertBill(Bill bill)
        {
            try
            {
                string query = "INSERT INTO [Bill] VALUES(@tableId, @totalAmount, @tipAmount, @comment, @date, @isOpen)";
                SqlParameter[] sqlParameters = new SqlParameter[6];
                sqlParameters[0] = new SqlParameter("@tableId", bill.Table.TableId);
                sqlParameters[1] = new SqlParameter("@totalAmount", bill.TotalAmount);
                sqlParameters[2] = new SqlParameter("@tipAmount", bill.TotalTip);
                sqlParameters[3] = new SqlParameter("@comment", string.IsNullOrEmpty(bill.Comment) ? DBNull.Value : bill.Comment);
                sqlParameters[4] = new SqlParameter("@date", bill.Date);
                sqlParameters[5] = new SqlParameter("@isOpen", bill.IsOpen);

                ExecuteEditQuery(query, sqlParameters);
            }
            catch
            {
                throw new Exception("inserting bill failed, try again");
            }
        }

        public int GetCurrentBillId()
        {
            //Grab the most up to date id for the bill to use to query orders
            string query = "SELECT MAX(billId) AS id FROM [Bill]";
            DataTable dataTable = ExecuteSelectQuery(query);
            DataRow row = dataTable.Rows[0];
            return (int)row["id"];
        }
        public void DeleteActiveBill(Table table)
        {
            string query = "DELETE FROM [Bill] WHERE tableId = @tableId AND IsOpen = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableId);

            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateBillTipAmount(Bill bill)
        {
            string query = "UPDATE [Bill] SET totalTip = @totalTip WHERE billId = @billId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@totalTip", bill.TotalTip);
            sqlParameters[1] = new SqlParameter("@billId", bill.BillId);

            ExecuteEditQuery(query, sqlParameters);
        }
        public void CloseBill(Bill bill)
        {
            string query = "UPDATE [Bill] SET IsOpen = 0 WHERE billId = @billId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@billId", bill.BillId);

            ExecuteEditQuery(query, sqlParameters);
        }
        public bool CheckForOpenBill(Table table)
        {
            string query = "SELECT billId, tableId, IsOpen FROM [Bill] WHERE tableId = @tableId AND isOpen = 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    return true;
                }
            }

            return false;
        }
        public Bill GetOpenBill(Table table)
        {
            try
            {
                string query = "SELECT billId, tableId, totalAmount, totalTip, date, isOpen FROM [Bill] WHERE tableId = @tableId AND isOpen = 1";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@tableId", table.TableId);

                DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
                DataRow row = dataTable.Rows[0];
                return ReadBill(row);
            }
            catch (Exception)
            {

                throw new Exception("recovering bill failed");
            }
        }
        private Bill ReadBill(DataRow dr)
        {
                Table table = new Table()
                {
                    TableId = (int)dr["tableId"],
                };

                Bill bill = new Bill()
                {

                    BillId = (int)dr["billId"],
                    Table = table,
                    TotalAmount = (decimal)dr["totalAmount"],
                    TotalTip = (decimal)dr["totalTip"],
                    Date = (DateTime)dr["date"],
                    Comment = dr["comment"].ToString(),
                    //IsOpen = (bool)dr["isOpen"]
                }; 
            
            return bill;
        }
    }
}

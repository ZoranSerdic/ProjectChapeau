using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class PaymentDAO : BaseDAO
    {
        public void CreateBill(Bill bill)
        {
            try
            {
                string query = "INSERT INTO [Bill] VALUES(@tableId, @totalAmount, @tipAmount, @comment, @date)";
                SqlParameter[] sqlParameters = new SqlParameter[5];
                sqlParameters[0] = new SqlParameter("@tableId", bill.Table.TableId);
                sqlParameters[1] = new SqlParameter("@totalAmount", bill.TotalAmount);
                sqlParameters[2] = new SqlParameter("@tipAmount", bill.TotalTip);
                sqlParameters[3] = new SqlParameter("@comment", string.IsNullOrEmpty(bill.Comment) ? DBNull.Value : bill.Comment);
                sqlParameters[4] = new SqlParameter("@date", bill.Date);

                ExecuteEditQuery(query, sqlParameters);
            }
            catch 
            {
                throw new Exception("creating bill failed, try again");
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
        public void AddPayment(Payment payment)
        {
            string query = "INSERT INTO [Payment] VALUES(@billId, @paymentMethod, @amount, @tip)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@billId", payment.BillId);
            sqlParameters[1] = new SqlParameter("@paymentMethod", payment.Method.ToString());
            sqlParameters[2] = new SqlParameter("@amount", payment.Amount);
            sqlParameters[3] = new SqlParameter("@tip", payment.Tip);

            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateOrderPaidStatus(Table table)
        {
            string query = "UPDATE [Order] SET isPayed = 1 WHERE tableId = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableId);

            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateTableStatusToFree(Table table)
        {
            string query = "UPDATE [Table] SET Status = @freeStatus WHERE tableId = @tableId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@freeStatus", TableStatus.Free.ToString());
            sqlParameters[1] = new SqlParameter("@tableId", table.TableId);

            ExecuteEditQuery(query, sqlParameters);
        }

        public List<OrderItem> GetAllItemsFromActiveOrders(Table table)
        {
            //This takes all the active orders (IsPaid = false) from the table and returns all the items to process the payment
            string query = @"SELECT m.name, m.price, c.amount, v.vat
                FROM [Order] 
                JOIN ConsistsOf AS c on [Order].orderId = c.orderId 
                JOIN MenuItem AS m ON c.menuItemId = m.menuItemId
                JOIN VAT AS v ON m.vatId = v.vatId
                WHERE [Order].tableId = @tableId AND [Order].IsPayed = 0";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tableId", table.TableId);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            List<OrderItem> orderItems = new List<OrderItem>();

            foreach(DataRow dr in dataTable.Rows)
            {
                orderItems.Add(ReadOrderItems(dr));
            }

            return orderItems;
        }
        private OrderItem ReadOrderItems(DataRow dr)
        {
            MenuItem item = new MenuItem
            {
                Name = (string)dr["name"],
                Price = (decimal)dr["price"],
                Vat = Convert.ToSingle(dr["vat"]) //I didn't realize SQL floats were actually doubles, so converting 
            };

            OrderItem order = new OrderItem
            {
                MenuItem = item,
                Amount = (int)dr["amount"]
            };

            return order;
        }
    }
}

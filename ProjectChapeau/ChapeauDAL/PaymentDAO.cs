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

            if(dataTable != null)
            {
                if(dataTable.Rows.Count > 0)
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
        public void DeleteActivePayments(Bill bill)
        {
            string query = "DELETE FROM [Payment] WHERE billId = @billId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@billId", bill.BillId);

            ExecuteEditQuery(query, sqlParameters);
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
        public List<Payment> GetActivePayments(Bill bill)
        {
            try
            {
                string query = "SELECT billId, paymentMethod, amount, tip FROM [Payment] WHERE billId = @billId";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@billId", bill.BillId);

                DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

                List<Payment> payments = new List<Payment>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    payments.Add(ReadPayment(dr));
                }

                return payments;
            }
            catch (Exception)
            {
                throw new Exception("recovering active payments failed");
            }
        }
        public List<OrderItem> GetAllItemsFromActiveOrders(Table table)
        {
            try
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

                foreach (DataRow dr in dataTable.Rows)
                {
                    orderItems.Add(ReadOrderItems(dr));
                }

                return orderItems;
            }
            catch (Exception)
            {

                throw new Exception("getting order items failed");
            }
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
                Date = Convert.ToDateTime(dr["date"]),
                IsOpen = (bool)dr["isOpen"],
                
            };

            return bill;
        }
        private Payment ReadPayment(DataRow dr)
        {
            Payment payment = new Payment()
            {
                BillId = (int)dr["billId"],
                Method = (PaymentMethod)Enum.Parse(typeof (PaymentMethod), dr["paymentMethod"].ToString()),
                Amount = (decimal)dr["amount"],
                Tip = (decimal)dr["tip"]
            };

            return payment;
        }
    }
}

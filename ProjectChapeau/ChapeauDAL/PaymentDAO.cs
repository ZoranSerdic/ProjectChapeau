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
        public void DeleteActivePayments(Bill bill)
        {
            string query = "DELETE FROM [Payment] WHERE billId = @billId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@billId", bill.BillId);

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
                string query = @"SELECT m.name, m.price, c.amount, v.vat, c.status
                FROM [Order] 
                JOIN ConsistsOf AS c on [Order].orderId = c.orderId 
                JOIN MenuItem AS m ON c.menuItemId = m.menuItemId
                JOIN VAT AS v ON m.vatId = v.vatId
                WHERE [Order].tableId = @tableId AND [Order].IsPayed = 0 AND c.status = 'Served'";

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

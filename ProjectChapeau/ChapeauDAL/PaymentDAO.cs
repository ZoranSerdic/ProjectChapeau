using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class PaymentDAO : BaseDAO
    {
        //Practice queries inserted into current active DB
        //INSERT INTO [Bill](tableId, totalAmount, totalTip, comment, date) VALUES(1, 500, 100, NULL, CURRENT_TIMESTAMP);
        //INSERT INTO[Payment](billId, paymentMethod, amount, tip) VALUES(IDENT_CURRENT('Bill'), 'Debit', 250, 50)
        public void CreateBill(int tableId, decimal totalAmount)
        {
            string query = "INSERT INTO [Bill] VALUES(@tableId, @totalAmount, 0, NULL, CURRENT_TIMESTAMP)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableId", tableId),
                new SqlParameter("@totalAmount", totalAmount)
            };

            ExecuteEditQuery(query, sqlParameters); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Bill
    {
        public int BillId { get; set; }
        public Table Table { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTip { get; set; }
        public bool IsPaid { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }

        public Bill(int billId, Table table, decimal totalAmount, decimal totalTip, bool isPaid, DateTime date, string? comment)
        {
            BillId = billId;
            Table = table;
            TotalAmount = totalAmount;
            TotalTip = totalTip;
            IsPaid = isPaid;
            Date = date;
            Comment = comment;
        }
    }
}

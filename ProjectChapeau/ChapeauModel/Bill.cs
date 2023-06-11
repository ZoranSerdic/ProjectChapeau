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
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public bool IsOpen { get; set; }

        public Bill() 
        { 

        }
        public Bill(Table table, decimal totalAmount, decimal totalTip, DateTime date, string? comment, bool isOpen)
        {
            Table = table;
            TotalAmount = totalAmount;
            TotalTip = totalTip;
            Date = date;
            Comment = comment;
            IsOpen = isOpen;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class BillService
    {
        private BillDAO billDAO;
        public BillService()
        {
            billDAO = new BillDAO();     
        }
        public List<Bill> GetAllBills()
        {
            return billDAO.GetAllBills();   
        }
        public void InsertBill(Bill bill)
        {
            billDAO.InsertBill(bill);
        }
        public int GetCurrentBillId()
        {
            return billDAO.GetCurrentBillId();
        }
        public void DeleteActiveBill(Table table)
        {
            billDAO.DeleteActiveBill(table);
        }
        public void UpdateBillTipAmount(Bill bill)
        {
            billDAO.UpdateBillTipAmount(bill);
        }
        public void CloseBill(Bill bill)
        {
            billDAO.CloseBill(bill);
        }
        public bool CheckForOpenBill(Table table)
        {
            return billDAO.CheckForOpenBill(table);
        }
        public Bill GetOpenBill(Table table)
        {
            return billDAO.GetOpenBill(table);
        }
    }
}

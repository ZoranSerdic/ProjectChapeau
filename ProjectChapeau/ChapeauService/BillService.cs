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
    }
}

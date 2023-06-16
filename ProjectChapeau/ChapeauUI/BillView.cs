using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class BillView : Form
    {
        Employee loggedInEmployee;
        public BillView(Employee employee)
        {
            this.loggedInEmployee = employee;
            InitializeComponent();
            BillService service = new BillService();
            DisplayBills(service.GetAllBills());
        }
        private void DisplayBills(List<Bill> bills)
        {
            //clear the listview before filling it
            listViewBills.Clear();

            //adding the columns
            listViewBills.Columns.Add("ID", 50);
            listViewBills.Columns.Add("Total amount", 100);
            listViewBills.Columns.Add("Tip", 90);
            listViewBills.Columns.Add("Date", 140);
            listViewBills.Columns.Add("Comment", 370);
            try
            {
                //adding the rows to the listview
                foreach (Bill bill in bills)
                {
                    ListViewItem li = new ListViewItem(bill.BillId.ToString());
                    li.SubItems.Add(bill.TotalAmount.ToString("0.00"));
                    li.SubItems.Add(bill.TotalTip.ToString("0.00"));
                    li.SubItems.Add(bill.Date.ToString("dd.MM.yyyy HH:mm"));
                    li.SubItems.Add(bill.Comment);
                    li.Tag = bill;
                    listViewBills.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerView overview = new ManagerView(this.loggedInEmployee);
            overview.ShowDialog();
            this.Close();
        }
    }
}

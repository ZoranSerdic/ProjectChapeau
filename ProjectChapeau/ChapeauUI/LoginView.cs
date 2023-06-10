using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            //Use this way to open the other forms in this order
            TableView tableView = new TableView();
            this.Hide();
            tableView.ShowDialog();
            this.Close();
        }

        private void btnOrderView_Click(object sender, EventArgs e)
        {
            // TODO: Bianca's TableOverview needs to provide orderView with TableID & Employee
            Table table = new Table();
            table.TableId = 12;
            table.Status = TableStatus.Occupied;

            Employee employee = new Employee();
            employee.EmployeeId = 10;
            employee.Pincode = "pincode";
            employee.FirstName = "Bob";
            employee.LastName = "AlsoBob";
            employee.Occupation = Role.Waiter;

            // ^ Remove after TableOverview form works / is created
            OrderView orderView = new OrderView(table, employee);
            this.Hide();
            orderView.ShowDialog();
            this.Close();
        }

        private void btnBarKitchenView_Click(object sender, EventArgs e)
        {
            BarKitchenView barKitchenView = new BarKitchenView();
            this.Hide();
            barKitchenView.ShowDialog();
            this.Close();
        }

        private void btnPaymentView_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.TableId = 2;
            table.Status = TableStatus.Occupied;
            PaymentView paymentView = new PaymentView(table);
            this.Hide();
            paymentView.ShowDialog();
            this.Close();
        }

        private void btnManagerView_Click(object sender, EventArgs e)
        {
            ManagerView managerView = new ManagerView();
            this.Hide();
            managerView.ShowDialog();
            this.Close();
        }
    }
}

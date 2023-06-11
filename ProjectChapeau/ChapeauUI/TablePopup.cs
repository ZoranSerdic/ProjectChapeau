using ChapeauModel;
using ChapeauService;
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
    public partial class TablePopup : Form
    {
        public Table table;
        public event EventHandler TableStatusUpdated;
        private TableService tableService;
        TableView tableView;

        public TablePopup(Table table, TableView tableView)
        {
            InitializeComponent();
            this.table = table;
            this.tableView = tableView;
            labelTableNumber.Text = $"Table {table.TableId}";
            labelTableHaveBeenOccupied.Text = $"Table {table.TableId} has been occupied";
        }

        private void buttonGenerateBill_Click(object sender, EventArgs e)
        {
            //if (table.Status == TableStatus.Occupied)
           // {
            //    PaymentView paymentView = new PaymentView(table);
             //   this.Hide();
              //  paymentView.ShowDialog();
              //  this.Close();
           // }
           // else
             //   MessageBox.Show("This table did not ordered anything yet", "Message", MessageBoxButtons.OK);
           
        }

        private void buttonCancelOccupation_Click(object sender, EventArgs e)
        {
            table.Status = TableStatus.Free;
            tableService = new TableService();
            tableService.UpdateTableStatus(table.TableId, table.Status);
            tableView.UpdateButtonAppearance(table);
            TableStatusUpdated?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}

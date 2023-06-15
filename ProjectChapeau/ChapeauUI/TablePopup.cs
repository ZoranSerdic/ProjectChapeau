using ChapeauDAL;
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
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class TablePopup : Form
    {
        public event EventHandler TableStatusUpdated;
        private TableService tableService;
        private OrderService orderService;
        TableView tableView;
        private Order order;
        public Table table;
        private Employee employee;
        private List<Order> orders;
        private ListViewItem.ListViewSubItem editingSubItem;

        public TablePopup(Table table, TableView tableView, Employee employee)
        {
            InitializeComponent();
            InitializeObjectsAndVariables(table, tableView, employee);

            if (CheckTable(table) == true)
            {
                this.listViewOrders.Show();
                this.buttonGenerateBill.Show();
                label_noOrder.Hide();
                buttonCancelOccupation.Hide();
                orders = GetOrders(table);
                foreach (var order in orders)
                {
                    DisplayOrderedItems(order);
                }
                listViewOrders.MouseClick += ListView_MouseClick;

            }
            else
            {
                this.listViewOrders.Hide();
                this.buttonGenerateBill.Hide();
                label_noOrder.Show();
                buttonCancelOccupation.Show();
            }

            labelTableNumber.Text = $"Table {table.TableId}";
            labelTableHaveBeenOccupied.Text = $"Table {table.TableId} has been occupied";
        }
        private void InitializeObjectsAndVariables(Table table, TableView tableView, Employee employee)
        {
            this.tableService = new TableService();
            this.orderService = new OrderService();
            this.order = new Order();

            this.table = table;
            this.tableView = tableView;
            this.employee = employee;
        }
        private bool CheckTable(Table table)
        {
            List<Order> unpaidOrders = orderService.GetUnpaidOrdersByTableId(table.TableId);

            return unpaidOrders.Count > 0;
        }
        private List<Order>? GetOrders(Table table)
        {
            List<Order> unpaidOrders = orderService.GetUnpaidOrdersByTableId(table.TableId);
            if (unpaidOrders.Count > 0) { return unpaidOrders; }
            else return null;
        }
        private void DisplayOrderedItems(Order order)
        {
            foreach (OrderItem orderItem in order.OrderedItems)
            {
                DateTime currentTime = DateTime.Now;
                TimeSpan timeSinceOrder = currentTime - order.Time;
                ListViewItem item = new ListViewItem(orderItem.MenuItem.Name);
                item.SubItems.Add(timeSinceOrder.ToString(@"hh\:mm"));
                item.SubItems.Add(orderItem.Status.ToString());

                item.Tag = orderItem.OrderItemId;
                listViewOrders.Items.Add(item);
            }
        }

        private void buttonGenerateBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentView payment = new PaymentView(table, employee);
            payment.ShowDialog();
            this.Close();
        }

        private void buttonCancelOccupation_Click(object sender, EventArgs e)
        {
            table.Status = TableStatus.Free;
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
            this.Hide();
            OrderView orderView = new OrderView(table, employee);
            orderView.ShowDialog();
            this.Close();
        }
        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewOrders.HitTest(e.Location);
            ListViewItem item = info.Item;
            int columnIndex = info.Item.SubItems.IndexOf(info.SubItem);

            if (item != null && columnIndex == 2)
            {
                editingSubItem = item.SubItems[columnIndex];
                Rectangle subItemRect = item.SubItems[columnIndex].Bounds;

                System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox();
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox.Items.Add("Served");
                comboBox.Bounds = new Rectangle(subItemRect.Left, subItemRect.Top, subItemRect.Width, subItemRect.Height);
                comboBox.Leave += ComboBox_Leave;

                listViewOrders.Controls.Add(comboBox);
                comboBox.Focus();
            }
        }
        private void ComboBox_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;

            if (listViewOrders.Controls.Contains(comboBox) && listViewOrders.SelectedItems.Count > 0)
            {
                int orderItemId = (int)listViewOrders.SelectedItems[0].Tag;
                int selectedIndex = comboBox.SelectedIndex;
                string newStatus = comboBox.Items[selectedIndex].ToString();

                orderService.UpdateOrderStatus(orderItemId, newStatus); // Update the order item status in the database

                editingSubItem.Text = newStatus; // Update the status in the ListViewItem

                listViewOrders.Controls.Remove(comboBox);
                comboBox.Dispose();
            }
        }
    }
}

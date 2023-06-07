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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class PaymentView : Form
    {
        PaymentService paymentService;
        Table table;
        Bill bill;
        List<OrderItem> items;

        decimal subTotal;
        float vat9, vat21;
        public decimal Total
        {
            get
            {
                return subTotal + (decimal)vat9 + (decimal)vat21;
            }
        }

        public PaymentView(Table table)
        {
            InitializeComponent();
            this.table = table;
            paymentService = new PaymentService();
            bill = new Bill();
            items = new List<OrderItem>();

            //Get all items, combine, display
            InitializeDisplay();

        }

        private void InitializeDisplay()
        {
            items = paymentService.GetAllItemsFromActiveOrders(table);
            items = CombineItems(items);

            DisplayItems(items);
            UpdateLabels();
            StyleListView();
        }
        private List<OrderItem> CombineItems(List<OrderItem> items)
        {
            //Combine duplicate items into one index
            List<OrderItem> combinedItems = new List<OrderItem>();
            List<string> addedNames = new List<String>();

            foreach (OrderItem item in items)
            {
                if(addedNames.Contains(item.MenuItem.Name))
                {
                    int indexOfItem = combinedItems.FindIndex(n => n.MenuItem.Name == item.MenuItem.Name);
                    combinedItems[indexOfItem].Amount += item.Amount;
                } 
                else
                {
                    combinedItems.Add(item);
                    addedNames.Add(item.MenuItem.Name);
                }
            }

            return combinedItems;
        }
        private void DisplayItems(List<OrderItem> items)
        {
            //Display each item the table ordered
            int index = 0;

            foreach (OrderItem item in items)
            {
                listviewItems.Items.Add(item.MenuItem.Name);

                decimal price = CalculateItemPrice(item);
                float vat = CalculateItemVat(item);

                listviewItems.Items[index].SubItems.Add(item.Amount.ToString());
                listviewItems.Items[index].SubItems.Add(price.ToString("€0.00"));
                listviewItems.Items[index].SubItems.Add(vat.ToString("€0.00"));
                index++;
            }
        }

        private decimal CalculateItemPrice(OrderItem item)
        {
            //Calculate price for display and add it to the running total
            decimal price = item.MenuItem.Price * item.Amount;
            subTotal += price;
            return price;
        }

        private float CalculateItemVat(OrderItem item)
        {
            //Calculate vat for display and add it to the running total for later
            float vat = (float)item.MenuItem.Price * item.MenuItem.Vat;
            if(item.MenuItem.Vat == (float)0.09) { vat9 += vat; } else { vat21 += vat; }
            return vat;
        }
        private void UpdateLabels()
        {
            lblTitle.Text = $"Table {table.TableId} - {DateTime.Now.ToString("d/M/yy")} - {DateTime.Now.ToString("h:mm tt")}";

            lblSubtotal.Text = subTotal.ToString("€0.00");
            lblvat9.Text = vat9.ToString("€0.00");
            lblvat21.Text = vat21.ToString("€0.00");
            lblTotal.Text = Total.ToString("€0.00");
            txtTotal.Text = Total.ToString("0.00");
        }
        private void StyleListView()
        {
            foreach (ListViewItem item in listviewItems.Items)
            {
                if(item.Index % 2 == 0 )
                {
                    item.BackColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.FromArgb(255, 210, 210, 210);
                }

            }

            //add padding between each item, don't ask me how it works
            int itemHeight = 25;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, itemHeight);
            listviewItems.SmallImageList = imgList;

        }

        private void listviewItems_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            //Change heading to red
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, 204, 68, 75));
            e.Graphics.FillRectangle(brush, e.Bounds);
            e.DrawText();
        }

        private void listviewItems_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //Various checks to make sure it's a number
            decimal value = 0;
            if (!string.IsNullOrEmpty(txtTotal.Text) && !decimal.TryParse(txtTotal.Text, out value) || value < 0 || value > 99999 || txtTotal.Text.StartsWith("0"))
            {
                txtTotal.Text = Total.ToString();
            }

            //If total amount in box is above total, set tip to zero. Extra will be calculated to tip later
            if(Convert.ToDecimal(txtTotal.Text) > Total)
            {
                txtTip.Text = "0.00";
            }
        }

        private void txtTip_Enter(object sender, EventArgs e)
        {
            //If the user wants to add a tip, make it nicer to use, and if a tip is added set total back to original total
            if (txtTip.Text == "0.00")
            {
                txtTip.Text = "";
            }

            txtTotal.Text = Total.ToString("0.00");
        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            //Various checks to make sure it's a number
            decimal value = 0;
            if (!string.IsNullOrEmpty(txtTip.Text) && !decimal.TryParse(txtTip.Text, out value) || value < 0 || value > 99999 || txtTip.Text.StartsWith("0"))
            {
                txtTip.Text = "0.00";
            }
        }

        private void listviewItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //stop selection from turning blue when clicking on it
            if(e.IsSelected) { e.Item.Selected = false; }
        }

    }
}

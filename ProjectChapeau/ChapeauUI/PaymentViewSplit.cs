using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;

namespace ChapeauUI
{
    public partial class PaymentViewSplit : Form
    {
        private Bill bill;
        private List<OrderItem> items;

        decimal subTotal;
        float vat9, vat21;
        public decimal Total
        {
            get
            {
                return subTotal + (decimal)vat9 + (decimal)vat21 + bill.TotalTip;
            }
        }
        public PaymentViewSplit(Bill bill, List<OrderItem> items)
        {
            InitializeComponent();
            this.bill = bill;
            this.items = items;

            InitializeDisplay();
        }
        private void InitializeDisplay()
        {
            CalculateItems(items);
            UpdateLabels();
            StyleListView();
        }

        private void CalculateItems(List<OrderItem> items)
        {
            //Calculate price for each item for display

            foreach (OrderItem item in items)
            { 
                decimal price = CalculateItemPrice(item);
                float vat = CalculateItemVat(item);
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
            //maybe simplify below variable..
            float vat = (float)Math.Round((float)item.MenuItem.Price * item.MenuItem.Vat, 2, MidpointRounding.AwayFromZero);

            if (item.MenuItem.Vat == (float)0.09)
            { vat9 += vat; }
            else if (item.MenuItem.Vat == (float)0.21)
            { vat21 += vat; }

            return vat;
        }
        private void UpdateLabels()
        {
            lblTitle.Text = $"Table {bill.Table.TableId} - {DateTime.Now.ToString("d/M/yy")} - {DateTime.Now.ToString("h:mm tt")}";

            lblSubtotal.Text = subTotal.ToString("€0.00");
            lblvat9.Text = vat9.ToString("€0.00");
            lblvat21.Text = vat21.ToString("€0.00");
            lblTotal.Text = Total.ToString("€0.00");
            lblTotalLeft.Text = Total.ToString("0.00");
        }

        private void StyleListView()
        {
            foreach (ListViewItem item in listviewPayments.Items)
            {
                if (item.Index % 2 == 0)
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
            listviewPayments.SmallImageList = imgList;

        }
        private void listviewPayments_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            //Change heading background to red and text to white
            SolidBrush brush = new SolidBrush(Color.FromArgb(255, 204, 68, 75)); //red background brush
            Font font = new Font("Segoe UI", 9, FontStyle.Bold); //header text
            StringFormat format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            e.Graphics.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, font, Brushes.White, e.Bounds, format);
        }
        private void listviewPayments_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listviewPayments_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //prevent header from being resized
            e.Cancel = true;
            e.NewWidth = listviewPayments.Columns[e.ColumnIndex].Width;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentView paymentview = new PaymentView(bill.Table);
            paymentview.ShowDialog();
            this.Close();
        }

    }
}

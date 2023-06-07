using ChapeauModel;
using ChapeauService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChapeauUI
{
    public partial class PaymentView : Form
    {
        private PaymentService paymentService;
        private Table table;
        private List<OrderItem> items;

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
            items = new List<OrderItem>();

            //Get all items, combine, display
            InitializeDisplay();

            //TODO - Add some sort of check to make sure the table has orders before checking out
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
            //maybe simplify below variable..
            float vat = (float)Math.Round((float)item.MenuItem.Price * item.MenuItem.Vat, 2, MidpointRounding.AwayFromZero);
           
            if(item.MenuItem.Vat == (float)0.09) 
                { vat9 += vat; } 
            else if (item.MenuItem.Vat == (float)0.21)
                { vat21 += vat; }

            return vat;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                ValidatePayment();
                Bill bill = new Bill();
                bill = CreateBill(bill);

                this.Hide();
                PaymentViewPay paymentviewpay = new PaymentViewPay(bill, SelectedMethod(), items);
                paymentviewpay.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR finalizing payment! \nERROR: {ex.Message}!");
            }
        }
        private void btnSplit_Click(object sender, EventArgs e)
        {
            try
            {
                ValidatePayment();
                Bill bill = new Bill();
                bill = CreateBill(bill);
                bill.TotalTip = 0;

                this.Hide();
                PaymentViewSplit paymentviewsplit = new PaymentViewSplit(bill, items);
                paymentviewsplit.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR finalizing payment! \nERROR: {ex.Message}!");
            }
        }

        private void ValidatePayment()
        {
            //Error checking method
            //Check if amount is actually above total

            if (Convert.ToDecimal(txtTotal.Text) < Total)
            {
                throw new Exception("Total amount is below total");
            }

            //Check if a payment method is selected
            //This is to retrieve which method calls the validation method. If split button calls it this check is ignored
            StackTrace stackTrace = new StackTrace();
            MethodBase methodBase = stackTrace.GetFrame(1).GetMethod();

            if (!rdbtnCash.Checked && !rdbtnCredit.Checked && !rdbtnDebit.Checked && methodBase.Name != "btnSplit_Click")
            {
                throw new Exception("No payment method selected");
            }

            //Edge case to make sure tip is never returned as null
            if(string.IsNullOrEmpty(txtTip.Text))
            {
                txtTip.Text = "0.00";
            }

        }
        private Bill CreateBill(Bill bill)
        {
            bill.Table = table;
            bill.TotalAmount = Total;
            bill.TotalTip = CalculateTip();
            bill.Date = DateTime.Now;
            bill.Comment = txtComment.Text;

            return bill;
        }
        private decimal CalculateTip()
        {
            decimal total = Convert.ToDecimal(txtTotal.Text);
            decimal tip = Convert.ToDecimal(txtTip.Text);

            //If the total input is above the Total, the extra is calculated as the tip, else return the value of tip
            if (total > Total)
            {
                return total - Total;
            }
            else
            {
                return tip;
            }
        }
        private PaymentMethod SelectedMethod()
        {
            //This can never return null due to it checking if a button is selected prior to this being able to run
            if(rdbtnCash.Checked)
            {
                return PaymentMethod.Cash;
            }
            else if(rdbtnCredit.Checked)
            {
                return PaymentMethod.Credit;
            }
            else
            {
                return PaymentMethod.Debit;
            }
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
                txtTotal.Text = Total.ToString("0.00");
                return;
            }

            //If total amount in box is above Total, set tip to zero. Extra will be calculated to tip later
            if(!string.IsNullOrEmpty(txtTotal.Text) && Convert.ToDecimal(txtTotal.Text) > Total)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to cancel payment?","Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                TableView tableview = new TableView();
                tableview.ShowDialog(); //pass employee?
                this.Close();
            }
        }

        private void listviewItems_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //prevent header from being resized
            e.Cancel = true;
            e.NewWidth = listviewItems.Columns[e.ColumnIndex].Width;
        }

        private void listviewItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //stop selection from turning blue when clicking on it
            if(e.IsSelected) { e.Item.Selected = false; }
        }

    }
}

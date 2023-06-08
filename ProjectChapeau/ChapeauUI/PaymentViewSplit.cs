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
        private List<Payment> payments;

        private decimal subTotal, amountRemaining;
        private float vat9, vat21;
        private decimal Total
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
            payments = new List<Payment>();

            InitializeDisplay();
        }
        private void InitializeDisplay()
        {
            CalculateItems(items);
            UpdateLabels();
            StyleListView();
            DisableInputFields();
        }

        private void CalculateItems(List<OrderItem> items)
        {
            //Calculate price for each item for display

            foreach (OrderItem item in items)
            { 
                CalculateItemPrice(item);
                CalculateItemVat(item);
            }

        }
        private void CalculateItemPrice(OrderItem item)
        {
            //Calculate price for display and add it to the running total
            decimal price = item.MenuItem.Price * item.Amount;
            subTotal += price;
        }
        private void CalculateItemVat(OrderItem item)
        {
            //Calculate vat for display and add it to the running total for later
            //maybe simplify below variable..
            float vat = (float)Math.Round((float)item.MenuItem.Price * item.MenuItem.Vat, 2, MidpointRounding.AwayFromZero);

            if (item.MenuItem.Vat == (float)0.09)
            { vat9 += vat; }
            else if (item.MenuItem.Vat == (float)0.21)
            { vat21 += vat; }

        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //Payment payment = new Payment(1, SelectedMethod(), 20, 500);
                //AddPaymentToTable(payment);
                //CalculateAmountRemaining(payment);
                //StyleListView(); //ran again to add gray and white separators to the table
                //payments.Add(payment);

                ProcessPayment();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"ERROR finalizing payment! \nERROR: {ex.Message}!");
            }
        }
        private void ProcessPayment()
        {

        }
        private void AddPaymentToTable(Payment payment)
        {
            int index = listviewPayments.Items.Count + 1;

            listviewPayments.Items.Add((index).ToString());

            listviewPayments.Items[index - 1].SubItems.Add(payment.Amount.ToString("€0.00"));
            listviewPayments.Items[index - 1].SubItems.Add(payment.Tip.ToString("€0.00"));
            listviewPayments.Items[index - 1].SubItems.Add(payment.Method.ToString());
        }
        private void CalculateAmountRemaining(Payment payment)
        {
            decimal amountRemaining = Convert.ToDecimal(lblTotalLeft.Text) - payment.Amount;
            lblTotalLeft.Text = amountRemaining.ToString("0.00");
            
        }
        private PaymentMethod SelectedMethod()
        {
            //This can never return null due to it checking if a button is selected prior to this being able to run
            if (rdbtnCash.Checked)
            {
                return PaymentMethod.Cash;
            }
            else if (rdbtnCredit.Checked)
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

        private void rdbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            DisableInputFields();
        }

        private void rdbtnDebit_CheckedChanged(object sender, EventArgs e)
        {
            EnableInputFields();
        }

        private void rdbtnCredit_CheckedChanged(object sender, EventArgs e)
        {
            EnableInputFields();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            decimal value = 0;
            if (!string.IsNullOrEmpty(txtTotal.Text) && !decimal.TryParse(txtTotal.Text, out value) || value < 0 || value > 99999 || txtTotal.Text.StartsWith("0"))
            {
                txtTotal.Text = "0.00";
                return;
            }
        }

        private void txtTip_TextChanged(object sender, EventArgs e)
        {
            decimal value = 0; 
            if (!string.IsNullOrEmpty(txtTip.Text) && !decimal.TryParse(txtTip.Text, out value) || value < 0 || value > 99999 || txtTip.Text.StartsWith("0"))
            {
                txtTip.Text = "0.00";
                return;
            }
        }

        private void DisableInputFields()
        {
            txtCardName.Enabled = false;
            txtCardName.Clear();
            txtCardNumber.Enabled = false;
            txtCardNumber.Clear();
            txtExpDate.Enabled = false;
            txtExpDate.Clear();
            txtCVV.Enabled = false;
            txtCVV.Clear();
        }
        private void EnableInputFields()
        {
            txtCardName.Enabled = true;
            txtCardNumber.Enabled = true;
            txtExpDate.Enabled = true;
            txtCVV.Enabled = true;
        }

    }
}

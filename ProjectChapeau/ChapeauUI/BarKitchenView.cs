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
    public partial class BarKitchenView : Form
    {
        public BarKitchenView()
        {
            InitializeComponent();
            // конструктор повинен приймати об'єкт класу робітник
            //if logged -in employee == bar then get-drinks else get - food)
        }
        private void DisplayOrders()
        {
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

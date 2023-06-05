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
    public partial class OrderFinalise : Form
    {
        public OrderFinalise()
        {
            InitializeComponent();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            // TODO: send orders to Kitchen / Bar database

            // Close OrderView
            // Not working as intended 
            #region closeForms
            //Form currentForm = Form.ActiveForm;

            //List<Form> formsToClose = new List<Form>();

            //// Add forms to the list
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form != currentForm)
            //    {
            //        formsToClose.Add(form);
            //    }
            //}

            //foreach (Form formToClose in formsToClose)
            //{
            //    formToClose.Close();
            //}
            #endregion

            // Go to Table View
            TableView tableView = new TableView();
            this.Hide();
            tableView.ShowDialog();
            this.Close();
        }
    }
}

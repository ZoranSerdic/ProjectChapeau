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
    public partial class TableView : Form
    { 
        private Table table;
        private Employee employee;
        private TableService tableService;
        public TableView(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            GenerateTables();
            whiteBackground.SendToBack();
            labelDateTime.Text = DateTime.Now.ToString("dd/MM/yy-HH:mm");
        }
        private void GenerateTables()
        {
            int buttonSize = 90;
            int spacing = 112;
            int numColumns = 2;
            int numRows = 5;

            tableService = new TableService();
            List<Table> tables = tableService.GetAllTables();

            int formWidth = numColumns * (buttonSize + spacing) + spacing;
            int formHeight = numRows * (buttonSize + spacing) + spacing;
            ClientSize = new Size(formWidth, formHeight);

            // Generate buttons for each table
            int tableIndex = 0;
            for (int col = 0; col < numColumns; col++)
            {
                for (int row = 0; row < numRows; row++)
                {
                    if (tableIndex >= tables.Count)
                    {
                        break;
                    }
                    tableIndex = CreateButtonForTable(buttonSize, spacing, tables, tableIndex, col, row);
                }
            }
        }

        private int CreateButtonForTable(int buttonSize, int spacing, List<Table> tables, int tableIndex, int col, int row)
        {
            Table table = tables[tableIndex];
            tableIndex++;

            Button button = new Button();
            button.Name = "buttonTable" + table.TableId;
            button.Text = $" {table.TableId} ";
            button.Size = new Size(buttonSize, buttonSize);

            if (table.Status == TableStatus.Free)
                button.BackColor = Color.Green;
            else
                button.BackColor = Color.Red;

            int buttonX = spacing + col * (buttonSize + spacing);
            int buttonY = spacing + row * (buttonSize + spacing);

            button.Location = new Point(buttonX, buttonY);
            button.Click += (sender, e) => Button_Click(table);

            Controls.Add(button);
            return tableIndex;
        }

        void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        void Button_Click(Table table)
        {
            // Update the table status
            table.Status = TableStatus.Occupied;
            UpdateButtonAppearance(table);

            // Update the table status in the database
            tableService.UpdateTableStatus(table.TableId, table.Status);
            TablePopup TablePopup = new TablePopup(table, this);
            TablePopup.ShowDialog();
            this.Refresh();
        }
        public void UpdateButtonAppearance(Table table)
        {
            Button button = Controls.Find("buttonTable" + table.TableId, true).FirstOrDefault() as Button;
            if (button != null)
            {
                if (table.Status == TableStatus.Occupied)
                {
                    button.BackColor = Color.Red;
                }
                else if (table.Status == TableStatus.Free)
                {
                    button.BackColor = Color.Green;
                }
            }
        }
    }
}

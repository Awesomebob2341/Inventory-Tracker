using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace Inventory_Tracker
{
    public partial class CheckPanel : Form
    {
        public string connectionString { get; set; }

        public CheckPanel()
        {
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QueryPart_Click(object sender, EventArgs e)
        {
            SQL_Commands SQL = new SQL_Commands(connectionString);
            Parts part = new Parts();
            part.PartNumber = PartNumber.Text;

            if (PartNumber.Text != "")
            {
                if (SQL.PartExists("Query Part", part))
                {
                    PartNumber.Text = "";
                    MessageBox.Show("That part is in stock. Proceed with the repair.","Part Found");
                }
                else
                {
                    MessageBox.Show("That part isn't in stock. Refer customer to a store with that part.", "Part Not Found");
                }
            }
            else
            {
                MessageBox.Show("You must enter a part number!","Warning");
            }
        }
    }
}

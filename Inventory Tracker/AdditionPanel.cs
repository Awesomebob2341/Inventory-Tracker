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
    public partial class AdditionPanel : Form
    {
        public string connectionString { get; set; }

        public AdditionPanel()
        {
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            SQL_Commands SQL = new SQL_Commands(connectionString);
            Parts part = new Parts();

            if (PartNumber.Text != "" && SerialNumber.Text != "")
            {
                part.PartNumber = PartNumber.Text;
                part.SerialNumber = SerialNumber.Text;
                
                SQL.AddToDB(part);
                SQL.AddToDB(part, part.Status);

                if (SQL.PartExists("Query Serial", part))
                {
                    MessageBox.Show("Database updated!", "Successful");
                }

                PartNumber.Text = SerialNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Please make sure all entries are filled before submitting inventory","Missing Information");
            }
        }
        
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When adding inventory, use a scanner to read the barcodes" +
                          "\nAs typing their values may result in errors." +
                          "\n" +
                          "\n-What's the difference between a part number and serial number?" +
                          "\nAll part numbers will start with APA or APL for Apple parts," +
                          "\nand for Samsung they'll start with SAM." +
                          "\nFor example a iPhone 7 screen part number is APA 10008-KIT." +
                          "\n" +
                          "\nA serial number is a unique idenfying code attached to parts so" +
                          "\nthat they can be tracked. Usually the label with the barcode will" +
                          "\nidentify itself as a serial number." +
                          "\n" +
                          "\nIf you have further questions about adding or checking inventory," +
                          "\nYou can contact your S&R manager, Field Quality Analyst or your" +
                          "\nsupervisor.", "Help");
        }
    }
}
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
    public partial class Post_Repair : Form
    {
        public string connectionString { get; set; }

        public Post_Repair()
        {
            InitializeComponent();

            TechName.Enabled = TechName.Visible = tech.Visible = false;
        }

        private void Close_Form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SQL_Commands SQL = new SQL_Commands(connectionString);
            Parts part = new Parts();

            part.PartNumber = PartNumber.Text;
            part.SerialNumber = SerialNumber.Text;
            part.Status = Status.Text;


            if (TechName.Enabled && TechName.Text != "" && PartNumber.Text != "" && SerialNumber.Text != "" && Status.Text != "(Select a status)")
            {
                part.TechName = TechName.Text;
                SQL.PostConsumtion(part);

                PartNumber.Text = "";
                SerialNumber.Text = "";
                Status.Text = "(Select a status)";

                TechName.Text = "";
                tech.Visible = false;
                TechName.Enabled = TechName.Visible = false;
            }
            else if (PartNumber.Text != "" && SerialNumber.Text != "" && Status.Text != "(Select a status)")
            {
                SQL.PostConsumtion(part);

                PartNumber.Text = "";
                SerialNumber.Text = "";
                Status.Text = "(Select a status)";
            }
            else
            {
                MessageBox.Show("Please make sure all entries are filled before submitting inventory", "Missing Information");
            }
        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status.Text == "DOA" || Status.Text == "Damaged")
            {
                TechName.Enabled = TechName.Visible = tech.Visible = true;
            }
            else
            {
                TechName.Enabled = TechName.Visible = tech.Visible = false;
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You must pick a part status. The different status are: " +
                          "\nAllocate: Use this status to receive inventory." +
                          "\nInstalled: Use this status to reflect that the part was used for a repair." +
                          "\nDOA: Dead on Arrival. Use this status to indicated that the part" +
                          "\nreceived was damaged prior to receiving.","Help");
        }
    }
}

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
using MySql.Data.MySqlClient; // needed to connect to MySQL database server

namespace Inventory_Tracker
{
    public partial class Tracker : Form
    {
        private static readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='<insert database path>'";
        //TODO: Modify existing code to function with MySQL Database Server
        
        public Tracker()
        {
            InitializeComponent();
        }

        private void Add_Inventory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdditionPanel addPanel = new AdditionPanel();
            addPanel.connectionString = connectionString;
            addPanel.ShowDialog();
            this.Visible = true;
        }

        private void Check_Inventory_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CheckPanel chkPanel = new CheckPanel();
            chkPanel.connectionString = connectionString;
            chkPanel.ShowDialog();
            this.Visible = true;
        }

        private void Post_Repair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Post_Repair postRepair = new Post_Repair();
            postRepair.connectionString = connectionString;
            postRepair.ShowDialog();
            this.Visible = true;
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
            //TODO: Switch over to a MySQL Database server

            //OleDbConnection connection = new OleDbConnection(connectionString);

            //connection.Open();
            //if (connection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("You are connected to a MySQL database server", "Success");
            //    connection.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Something went worng with the MySQL database server", "Failure");
            //    connection.Close();
            //}
        }
    }
}

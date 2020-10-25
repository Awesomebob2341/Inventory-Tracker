namespace Inventory_Tracker
{
    partial class Tracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Post_Repair = new System.Windows.Forms.Button();
            this.Check_Inventory = new System.Windows.Forms.Button();
            this.Add_Inventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Post_Repair
            // 
            this.Post_Repair.Location = new System.Drawing.Point(313, 105);
            this.Post_Repair.Name = "Post_Repair";
            this.Post_Repair.Size = new System.Drawing.Size(132, 60);
            this.Post_Repair.TabIndex = 3;
            this.Post_Repair.Text = "Post Repair";
            this.Post_Repair.UseVisualStyleBackColor = true;
            this.Post_Repair.Click += new System.EventHandler(this.Post_Repair_Click);
            // 
            // Check_Inventory
            // 
            this.Check_Inventory.Location = new System.Drawing.Point(175, 105);
            this.Check_Inventory.Name = "Check_Inventory";
            this.Check_Inventory.Size = new System.Drawing.Size(132, 60);
            this.Check_Inventory.TabIndex = 2;
            this.Check_Inventory.Text = "Check Inventory";
            this.Check_Inventory.UseVisualStyleBackColor = true;
            this.Check_Inventory.Click += new System.EventHandler(this.Check_Inventory_Click);
            // 
            // Add_Inventory
            // 
            this.Add_Inventory.Location = new System.Drawing.Point(37, 105);
            this.Add_Inventory.Name = "Add_Inventory";
            this.Add_Inventory.Size = new System.Drawing.Size(132, 60);
            this.Add_Inventory.TabIndex = 1;
            this.Add_Inventory.Text = "Add Inventory";
            this.Add_Inventory.UseVisualStyleBackColor = true;
            this.Add_Inventory.Click += new System.EventHandler(this.Add_Inventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to InviSys, your inventory tracking system.\r\n            Please select an" +
    " option to continue.";
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Post_Repair);
            this.Controls.Add(this.Check_Inventory);
            this.Controls.Add(this.Add_Inventory);
            this.Name = "Tracker";
            this.Text = "InviSys";
            this.Load += new System.EventHandler(this.Tracker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Post_Repair;
        private System.Windows.Forms.Button Check_Inventory;
        private System.Windows.Forms.Button Add_Inventory;
        private System.Windows.Forms.Label label1;
    }
}


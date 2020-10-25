namespace Inventory_Tracker
{
    partial class Post_Repair
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
            this.label1 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tech = new System.Windows.Forms.Label();
            this.TechName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Close_Form = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.Blue;
            this.Help.Location = new System.Drawing.Point(693, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(50, 24);
            this.Help.TabIndex = 1;
            this.Help.Text = "Help";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // PartNumber
            // 
            this.PartNumber.Location = new System.Drawing.Point(86, 87);
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Size = new System.Drawing.Size(191, 22);
            this.PartNumber.TabIndex = 2;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(283, 87);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(191, 22);
            this.SerialNumber.TabIndex = 3;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "(Select a status)",
            "Allocated",
            "Damaged",
            "DOA",
            "Installed"});
            this.Status.Location = new System.Drawing.Point(480, 87);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(191, 24);
            this.Status.TabIndex = 4;
            this.Status.Text = "(Select a status)";
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Part Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serial Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // tech
            // 
            this.tech.AutoSize = true;
            this.tech.Location = new System.Drawing.Point(280, 112);
            this.tech.Name = "tech";
            this.tech.Size = new System.Drawing.Size(77, 17);
            this.tech.TabIndex = 9;
            this.tech.Text = "Technician";
            // 
            // TechName
            // 
            this.TechName.Location = new System.Drawing.Point(283, 132);
            this.TechName.Name = "TechName";
            this.TechName.Size = new System.Drawing.Size(191, 22);
            this.TechName.TabIndex = 8;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(283, 160);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(191, 60);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit Part";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Close_Form
            // 
            this.Close_Form.AutoSize = true;
            this.Close_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Form.ForeColor = System.Drawing.Color.Blue;
            this.Close_Form.Location = new System.Drawing.Point(12, 6);
            this.Close_Form.Name = "Close_Form";
            this.Close_Form.Size = new System.Drawing.Size(67, 24);
            this.Close_Form.TabIndex = 12;
            this.Close_Form.Text = "< Back";
            this.Close_Form.Click += new System.EventHandler(this.Close_Form_Click);
            // 
            // Post_Repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 250);
            this.ControlBox = false;
            this.Controls.Add(this.Close_Form);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.tech);
            this.Controls.Add(this.TechName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.PartNumber);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.label1);
            this.Name = "Post_Repair";
            this.Text = "Post Repair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.TextBox PartNumber;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tech;
        private System.Windows.Forms.TextBox TechName;
        private System.Windows.Forms.Button Submit;
    private System.Windows.Forms.Label Close_Form;
}
}
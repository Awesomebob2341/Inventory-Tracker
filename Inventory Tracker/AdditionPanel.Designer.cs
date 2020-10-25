namespace Inventory_Tracker
{
    partial class AdditionPanel
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
            this.CloseForm = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPart = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseForm
            // 
            this.CloseForm.AutoSize = true;
            this.CloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.ForeColor = System.Drawing.Color.Blue;
            this.CloseForm.Location = new System.Drawing.Point(12, 9);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(67, 24);
            this.CloseForm.TabIndex = 0;
            this.CloseForm.Text = "< Back";
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // PartNumber
            // 
            this.PartNumber.Location = new System.Drawing.Point(85, 89);
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Size = new System.Drawing.Size(191, 22);
            this.PartNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Part Number";
            // 
            // SerialNumber
            // 
            this.SerialNumber.Location = new System.Drawing.Point(282, 89);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(191, 22);
            this.SerialNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serial Number";
            // 
            // AddPart
            // 
            this.AddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPart.Location = new System.Drawing.Point(186, 132);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(191, 60);
            this.AddPart.TabIndex = 7;
            this.AddPart.Text = "Add Part";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.Blue;
            this.Help.Location = new System.Drawing.Point(493, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(50, 24);
            this.Help.TabIndex = 8;
            this.Help.Text = "Help";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // AdditionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 250);
            this.ControlBox = false;
            this.Controls.Add(this.Help);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartNumber);
            this.Controls.Add(this.CloseForm);
            this.Name = "AdditionPanel";
            this.Text = "Add Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseForm;
        private System.Windows.Forms.TextBox PartNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SerialNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Label Help;
    }
}
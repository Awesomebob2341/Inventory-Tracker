namespace Inventory_Tracker
{
    partial class CheckPanel
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
            this.Help = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.QueryPart = new System.Windows.Forms.Button();
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
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.Blue;
            this.Help.Location = new System.Drawing.Point(388, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(50, 24);
            this.Help.TabIndex = 1;
            this.Help.Text = "Help";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Part Number";
            // 
            // PartNumber
            // 
            this.PartNumber.Location = new System.Drawing.Point(134, 84);
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Size = new System.Drawing.Size(191, 22);
            this.PartNumber.TabIndex = 3;
            // 
            // QueryPart
            // 
            this.QueryPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryPart.Location = new System.Drawing.Point(134, 126);
            this.QueryPart.Name = "QueryPart";
            this.QueryPart.Size = new System.Drawing.Size(191, 60);
            this.QueryPart.TabIndex = 4;
            this.QueryPart.Text = "Check for Part";
            this.QueryPart.UseVisualStyleBackColor = true;
            this.QueryPart.Click += new System.EventHandler(this.QueryPart_Click);
            // 
            // CheckPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 250);
            this.ControlBox = false;
            this.Controls.Add(this.QueryPart);
            this.Controls.Add(this.PartNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.CloseForm);
            this.Name = "CheckPanel";
            this.Text = "CheckPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseForm;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PartNumber;
        private System.Windows.Forms.Button QueryPart;
    }
}
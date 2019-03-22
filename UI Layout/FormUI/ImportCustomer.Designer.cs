namespace FormUI
{
    partial class Import_Customer
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
            this.newCustomerForm = new System.Windows.Forms.Button();
            this.existingCustomerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCustomerForm
            // 
            this.newCustomerForm.Location = new System.Drawing.Point(0, 3);
            this.newCustomerForm.Name = "newCustomerForm";
            this.newCustomerForm.Size = new System.Drawing.Size(188, 58);
            this.newCustomerForm.TabIndex = 0;
            this.newCustomerForm.Text = "New Customer";
            this.newCustomerForm.UseVisualStyleBackColor = true;
            this.newCustomerForm.Click += new System.EventHandler(this.newCustomerForm_Click);
            // 
            // existingCustomerForm
            // 
            this.existingCustomerForm.Location = new System.Drawing.Point(194, 3);
            this.existingCustomerForm.Name = "existingCustomerForm";
            this.existingCustomerForm.Size = new System.Drawing.Size(188, 58);
            this.existingCustomerForm.TabIndex = 1;
            this.existingCustomerForm.Text = "Existing Customer";
            this.existingCustomerForm.UseVisualStyleBackColor = true;
            // 
            // Import_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 64);
            this.Controls.Add(this.existingCustomerForm);
            this.Controls.Add(this.newCustomerForm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 103);
            this.MinimumSize = new System.Drawing.Size(399, 103);
            this.Name = "Import_Customer";
            this.Text = "Import_Customer_Information";
            this.Load += new System.EventHandler(this.Import_Customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newCustomerForm;
        private System.Windows.Forms.Button existingCustomerForm;
    }
}
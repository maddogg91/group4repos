namespace FormUI
{
    partial class CreateTicket
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
            this.submitTicket = new System.Windows.Forms.Button();
            this.taskTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.importCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket\'s priority level:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // submitTicket
            // 
            this.submitTicket.Location = new System.Drawing.Point(316, 445);
            this.submitTicket.Name = "submitTicket";
            this.submitTicket.Size = new System.Drawing.Size(235, 58);
            this.submitTicket.TabIndex = 2;
            this.submitTicket.Text = "Create Ticket";
            this.submitTicket.UseVisualStyleBackColor = true;
            this.submitTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(25, 115);
            this.taskTextBox.MaxLength = 5000;
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(794, 168);
            this.taskTextBox.TabIndex = 3;
            this.taskTextBox.Text = "";
            this.taskTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the customer\'s issue: (300 words or less)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(413, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 5;
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Unassigned",
            "Low",
            "Moderate",
            "High",
            "Important",
            "Overdue"});
            this.priorityBox.Location = new System.Drawing.Point(25, 339);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(102, 21);
            this.priorityBox.TabIndex = 6;
            this.priorityBox.SelectedIndexChanged += new System.EventHandler(this.priorityBox_SelectedIndexChanged);
            // 
            // importCustomer
            // 
            this.importCustomer.Location = new System.Drawing.Point(25, 34);
            this.importCustomer.Name = "importCustomer";
            this.importCustomer.Size = new System.Drawing.Size(110, 23);
            this.importCustomer.TabIndex = 7;
            this.importCustomer.Text = "Import Customer";
            this.importCustomer.UseVisualStyleBackColor = true;
            this.importCustomer.Click += new System.EventHandler(this.importCustomer_Click);
            // 
            // CreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 502);
            this.Controls.Add(this.importCustomer);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.submitTicket);
            this.Controls.Add(this.label1);
            this.Name = "CreateTicket";
            this.Text = "Create New Ticket";
            this.Load += new System.EventHandler(this.TierICreateTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox taskTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitTicket;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Button importCustomer;
    }
}


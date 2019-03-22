using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{

    public partial class CreateTicket : Form
    {
        string priority= "unassigned";
        string task;
        public CreateTicket()
        {
            InitializeComponent();
        }
        //Select Priority Button
       
            //holds the priority when selected

          
        private void priorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (priorityBox.SelectedIndex != -1)
            {
                priority = priorityBox.SelectedItem.ToString();

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] words = taskTextBox.Text.Split();
            int wordCount = words.Length;
            if (wordCount > 300)
            {
                taskTextBox.Text = string.Join(" ", words.Take(300));
                MessageBox.Show("Word limit reached!");
            }
            task = string.Join(" ", words);
            textBox1.Text = (300 - wordCount).ToString();
        }
        public void label1_Click(object sender, EventArgs e)
        {

        }
        public Ticket CreateDefaultTicket()
        {

            string key = Ticket.GeneratePrimaryKey();
            string status = Ticket.SelectStatus();


            //Create default ticket
            Ticket default_ticket = new Ticket(key, status, "employee ID", priority, task,
                "CUSTOMER", "March 11th, 2019");

            return default_ticket;


        }
        //Submit Ticket Button
        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Ticket generated with {priority} priority");
            Ticket newTicket = CreateDefaultTicket();
            MessageBox.Show($"Ticket#: {newTicket.T_id} created!\nCurrent status: {newTicket.Status}" +
                $"\nPriority: {newTicket.Priority}\nIssue: {task}");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TierICreateTicket_Load(object sender, EventArgs e)
        {

        }

        private void importCustomer_Click(object sender, EventArgs e)
        {
            Import_Customer f = new Import_Customer();
            f.ShowDialog();
        }
    }
}


    


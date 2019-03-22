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
    public partial class NewCustomer : Form
    {
        string fname, lname;
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
           
           
        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {
            fname = firstNameBox.Text;
        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {
            lname = lastNameBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{fname} {lname}");
        }
    }
}

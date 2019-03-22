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
    public partial class Import_Customer : Form
    {
        public Import_Customer()
        {
            InitializeComponent();
        }

        private void Import_Customer_Load(object sender, EventArgs e)
        {

        }

        private void newCustomerForm_Click(object sender, EventArgs e)
        {
            NewCustomer c = new NewCustomer();
            c.ShowDialog();
        }
    }
}

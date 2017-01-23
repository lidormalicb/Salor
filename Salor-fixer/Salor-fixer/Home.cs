using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Salor_fixer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open ope2n = new open();
            ope2n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seller sellerma = new seller();
            sellerma.Show();
        }

        private void custpmers_button_Click(object sender, EventArgs e)
        {
            customers cus2 = new customers();
            cus2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            status_add add = new status_add();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            price priceUP = new price();
            priceUP.Show();
        }
    }
}

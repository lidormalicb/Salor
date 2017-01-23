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
    public partial class open : Form
    {
        SqlConnection conncet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB-work\fix-phone.mdf;Integrated Security=True;Connect Timeout=30");
        public open()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Customer.SelectedIndex = -1;
            Seller.SelectedIndex = -1;
            Phone.SelectedIndex = -1;
            Problem.Clear();
            IMEI.Clear();
            Price.Clear();
            MessageBox.Show("פרטי הקריאה התאפסו בהצלחה", "איפוס קריאה");
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            conncet.Open();
            SqlCommand cmd = new SqlCommand(@"insert into open_service
                 (id_customers, id_seller, problem, imei, id_phone, price)
              values
              ('" + Customer.Text + "','" + Seller.Text + "','" + Problem.Text + "','" + IMEI.Text + "','" + Phone.Text + "','" + Price.Text + "')", conncet);
            cmd.ExecuteNonQuery();
            conncet.Close();
            MessageBox.Show("הנתונים נשמרו", "הנתונים הוזנו במערכת ונשמרו");
            Customer.SelectedIndex = -1;
            Seller.SelectedIndex = -1;
            Phone.SelectedIndex = -1;
            Problem.Clear();
            IMEI.Clear();
            Price.Clear();
        }

        private void lachoch(object sender, EventArgs e)
        {
            customers cus = new customers();
            cus.Show();
        }

        private void new_lachoch_Click(object sender, EventArgs e)
        {
            customers cus = new customers();
            cus.Show();
        }

        private void men_seller(object sender, EventArgs e)
        {
            seller seller2 = new seller();
            seller2.Show();
        }

        private void exit(object sender, FormClosingEventArgs e)
        {

        }

        private void ex(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("בלחיצה על אישור-המערכת תבצע יציאה מלחון זה.", "אישור יציאה",
            MessageBoxButtons.OK, MessageBoxIcon.Question);
            {
                this.Activate();
            }
        }

        private void open_Load(object sender, EventArgs e)
        {
            

        }

        private void help_c(object sender, EventArgs e)
        {
            helper hlp = new helper();
            hlp.Show();
        }

        private void open_ser(object sender, EventArgs e)
        {
            open serv_op = new open();
            serv_op.Show();
        }

        private void update_srv(object sender, EventArgs e)
        {
            update_status update_sts = new update_status();
            update_sts.Show();
        }
    }
}

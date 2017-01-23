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
    public partial class price : Form
    {
        SqlConnection conncet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB-work\fix-phone.mdf;Integrated Security=True;Connect Timeout=30");
        public price()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conncet.Open();
            SqlCommand cmd = new SqlCommand(@"insert into price
                 (info, price)
              values
              ('" + info.Text + "','" + textBox2.Text + "')", conncet);
            cmd.ExecuteNonQuery();
            conncet.Close();
            MessageBox.Show("הודעת עדכון", "המחירון תקלות עודכן ונשמר");
            textBox2.Clear();
            info.Clear();
        }
    }
}

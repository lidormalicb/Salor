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
    public partial class seller : Form
    {
        SqlConnection conncet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB-work\fix-phone.mdf;Integrated Security=True;Connect Timeout=30");

        public seller()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            conncet.Open();
            SqlCommand cmd = new SqlCommand(@"insert into seller
                 (seller-name)
              values
              ('" + name.Text +  "')", conncet);
            cmd.ExecuteNonQuery();
            conncet.Close();
            MessageBox.Show("הנתונים נשמרו", "הנתונים הוזנו במערכת ונשמרו");
            name.Clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            name.Clear();
            MessageBox.Show("פרטי המוכר נוקו בהצלחה ", "איפוס פרטי מוכר");
        }
    }
}

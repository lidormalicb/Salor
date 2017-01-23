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
    public partial class status_add : Form
    {
        SqlConnection conncet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB-work\fix-phone.mdf;Integrated Security=True;Connect Timeout=30");
        public status_add()
        {
            InitializeComponent();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            conncet.Open();
            SqlCommand cmd = new SqlCommand(@"insert into info_status
                 (info, precent)
              values
              ('" + status_txt.Text + "','" + precent_txt.Text + "')", conncet);
            cmd.ExecuteNonQuery();
            conncet.Close();
            MessageBox.Show("הנתונים נשמרו", "הנתונים הוזנו במערכת ונשמרו");
            status_txt.Clear();
            precent_txt.Clear();
        }
    }
}

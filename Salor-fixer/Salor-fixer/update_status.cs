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
    public partial class update_status : Form
    {
        SqlConnection conncet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB-work\fix-phone.mdf;Integrated Security=True;Connect Timeout=30");
        public update_status()
        {
            InitializeComponent();
        }
        private void displayTime()
        {
            time_lbl.Text = DateTime.Now.ToShortTimeString();
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            conncet.Open();
            SqlCommand cmd = new SqlCommand(@"insert into time_fix
                 (lachoch, id_phone, imei, time, info)
              values
              ('" + lachoch.Text + "','" + phone.Text + "','" + info.Text + "','" + imei.Text + "','" + time_lbl.Text + "','" + info.Text + "')", conncet);
            cmd.ExecuteNonQuery();
            conncet.Close();
            MessageBox.Show("הנתונים נשמרו", "הנתונים הוזנו במערכת ונשמרו");
            lachoch.SelectedIndex = -1;
            info.SelectedIndex = -1;
            phone.SelectedIndex = -1;
            imei.Clear();
        }

        private void update_status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDBfix_phoneDataSet.info_status' table. You can move, or remove it, as needed.
            this.info_statusTableAdapter.Fill(this.allDBfix_phoneDataSet.info_status);

        }
    }
}

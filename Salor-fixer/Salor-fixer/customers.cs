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
    public partial class customers : Form
    {
        SqlConnection conncet = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB-work\fix-phone.mdf;Integrated Security=True;Connect Timeout=30");
        public customers()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            city.SelectedIndex = -1;
            phone1.Clear();
            phone2.Clear();
            street.Clear();
            name.Clear();
            MessageBox.Show("פרטי הלקוח התאפסו בהצלחה", "איפוס פרטי לקוח");
        }

        private void save_Click(object sender, EventArgs e)
        {
            conncet.Open();
            SqlCommand cmd = new SqlCommand(@"insert into customers
                 (cus-name, cus-street, cus-city, cus-tel, cus-tel2)
              values
              ('" + name.Text + "','" + street.Text + "','" + city.Text + "','" + phone1.Text + "','" + phone2.Text + "')", conncet);
            cmd.ExecuteNonQuery();
            conncet.Close();
            MessageBox.Show("שמירת לקוח", "הלקוח נשמר בהצלחה במערכת");
            city.SelectedIndex = -1;
            name.Clear();
            street.Clear();
            phone2.Clear();
            phone1.Clear();
        }

        private void ex(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("האם הינך בטוח שברצונך לצאת מהתוכנה?", "אישור יציאה",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void exit(object sender, FormClosingEventArgs e)
        {

        }
    }
}

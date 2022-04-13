using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    public partial class dang_nhap : Form
    {
        public SqlConnection sqlconn = new SqlConnection(); 
        public dang_nhap()
        {
            // form nay dung de dang nhap vao he thong
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Dang_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                String str = @"Data Source=LAPTOP-FMCUOBFE\SQLEXPRESS;Initial Catalog=ADB1_N13_DATH#02;Integrated Security=True";
                // xai cai string nay nha Hieu
                // String str = @"Data Source=LAPTOP-FMCUOBFE\SQLEXPRESS;Initial Catalog=ADB1_N13_DATH#02;Integrated Security=True";
                String query = "select * from sanpham";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("connect successfully");

                }
                else
                    MessageBox.Show("failed");  
                SqlCommand cmd = new SqlCommand(query, con);
                //con.Open();
                DataSet ds = new DataSet();
                MessageBox.Show("connect with sql server");
                con.Close();
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}

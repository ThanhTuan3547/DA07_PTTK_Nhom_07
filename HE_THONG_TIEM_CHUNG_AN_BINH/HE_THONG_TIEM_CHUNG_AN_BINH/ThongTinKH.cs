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

    public partial class ThongTinKH : Form
    {
        public ThongTinKH()
        {
            InitializeComponent();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            string username = dang_nhap.username; // ở form khác cứ lấy code "dang_nhap.username" 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

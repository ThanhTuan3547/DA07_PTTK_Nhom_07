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
        private ConnectDB cdb;
        private SqlConnection cnn;
        public dang_nhap()
        {
            InitializeComponent();

        }

        public dang_nhap(ConnectDB cdb, SqlConnection cnn)
        {
            // set variable before passing
            this.cdb = cdb;
            this.cnn = cnn;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            this.Closing += Dang_nhap_Closing; ;
            Role_box.DisplayMember = "Text";
            Role_box.ValueMember = "Value";
            Role_box.Items.Add(new { Text = "Nhân viên", Value = "Nhân viên" });
            Role_box.Items.Add(new { Text = "Khách hàng", Value = "Khách hàng" });
        }

        private void Dang_nhap_Closing(object sender, CancelEventArgs e)
        {
            this.cdb.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Dang_nhap_Click(object sender, EventArgs e)
        {
            string curItem = (this.Role_box.SelectedItem as dynamic).Value;
            if (curItem == "Nhân viên")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM NHANVIEN WHERE TAIKHOAN ='"
                    + ID_box.Text.ToString() + "'" + " AND MATKHAU ='" + Password_box.Text.ToString() + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Hehe");
                    this.Hide();
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai, xin hãy kiểm tra lại !");
            }
            if (curItem == "Khách hàng")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM KHACHHANG WHERE TAIKHOAN ='"
                     + ID_box.Text.ToString() + "'" + " AND MATKHAU ='" + Password_box.Text.ToString() + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    ThongTinKH TTKH = new ThongTinKH(this, this.cnn);
                    this.Hide();
                    ThongTinKH.Show();
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai, xin hãy kiểm tra lại !");

            }

        }

        private void textBox_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

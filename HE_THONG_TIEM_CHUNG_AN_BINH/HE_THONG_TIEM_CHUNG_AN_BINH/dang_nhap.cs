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
        private Dang_ky_thong_tin_khach_hang nv_tab;
        public static string username = ""; // biến global tài khoản người đăng nhập 
        public static string MaNVorKH = ""; // biến global mã nhân viên / khách hàng đăng nhập 
        public dang_nhap()
        {
            InitializeComponent();

        }

        public dang_nhap(ConnectDB cdb, SqlConnection cnn)
        {

            // set variable before passing
            this.nv_tab = new Dang_ky_thong_tin_khach_hang(cnn, this);
            this.cdb = cdb;
            this.cnn = cnn;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            this.Closing += Dang_nhap_Closing; 
            Role_box.DisplayMember = "Text";
            Role_box.ValueMember = "Value";
            Role_box.Items.Add(new { Text = "Nhân viên", Value = "Nhân viên" });
            Role_box.Items.Add(new { Text = "Khách hàng", Value = "Khách hàng" });
            //Role_box.SelectedItem = "Khách hàng";
        }

        private void Dang_nhap_Closing(object sender, CancelEventArgs e)
        {
            this.cdb.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Dang_nhap_Click(object sender, EventArgs e) // ở trên này là lớp giao diện, chỉ check mấy cái kiểu như chuỗi nhập vào hợp lệ hay không, hợp lệ rồi mới gọi xuống lớp controller, controller mới gọi xuống DAO
        {
            
            if (ID_box.Text.Length < 3 || Password_box.Text.Length < 3)
            {
                MessageBox.Show("tài khoản và mật khẩu phải ít nhất 3 kí tự");

            }
            if (this.Role_box.SelectedItem == null) {
                MessageBox.Show("Vui lòng chọn 1 vai trò");
            }
            else
            {
                string curItem = (this.Role_box.SelectedItem as dynamic).Value;
                int role;
                if (curItem == "Khách hàng")
                    role = 1;
                else
                    role = 0;

                username = ID_box.Text; // gán biến username 
                KhachHang dangnhap = new KhachHang();

                if (dangnhap.Loggin(cnn, role, ID_box.Text, Password_box.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    if (role == 1) // show trang khach hang
                    {
                        this.Hide();
                        KH_main KH1 = new KH_main();
                        KH1.Show();
                    }
                    else // show trang nhan vien 
                    {
                        this.Hide();
                        nv_tab.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai, xin hãy kiểm tra lại !");
                }
            }
            

        }

        private void textBox_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

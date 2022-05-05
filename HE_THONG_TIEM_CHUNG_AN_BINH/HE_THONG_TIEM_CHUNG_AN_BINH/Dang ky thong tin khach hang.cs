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
    public partial class Dang_ky_thong_tin_khach_hang : Form
    {
        private SqlConnection cnn;
        public KhachHang kh;
        public static int makh;
        public Dang_Ky_Tiem_Chung _dangkytiem_tab = null;
        public Dang_ky_thong_tin_khach_hang(SqlConnection cnn ,dang_nhap dn)
        {
            InitializeComponent();
            this.cnn = cnn;
            DataGridViewButtonColumn btn_col = new DataGridViewButtonColumn();
            btn_col.Name = "Xem";
            btn_col.HeaderText = "Thông tin chi tiết";
            btn_col.Text = "Xem";
            KhachHang kh = new KhachHang();
            this.kh = kh;
            btn_col.UseColumnTextForButtonValue = true;
            dataGridView1_DS_KhachHang.Columns.Add(btn_col);

            //Dang_Ky_Tiem_Chung DKTiemchung_tab = new Dang_Ky_Tiem_Chung();
            //this._dangkytiem_tab = DKTiemchung_tab;
            // grid view danh sach khach hang
            dataGridView1_DS_KhachHang.Columns[0].DataPropertyName = "Makh";
            dataGridView1_DS_KhachHang.Columns[1].DataPropertyName = "HoTenKH";
            dataGridView1_DS_KhachHang.Columns[2].DataPropertyName = "NgaySinh";
            dataGridView1_DS_KhachHang.Columns[3].DataPropertyName = "SDT";
            dataGridView1_DS_KhachHang.Columns[4].DataPropertyName = "DiaChi";
            dataGridView1_DS_KhachHang.DataSource = kh.Timkiem(cnn, "");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_DangKyKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();

            if (textBox_HoTen.Text.Length == 0 || comboBox_GioiTinh.SelectedItem == null || dateTimePicker_ngaySinh == null || textBox_DiaChi.Text.Length == 0 || textBox_SDT.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else if (DateTime.Today.Year - dateTimePicker_ngaySinh.Value.Year < 18)
            {
                if (textBox_TenNguoiGiamHo.Text.Length == 0 || textBox_MoiQuanHe.Text.Length == 0 || textBox_SDT_NGH.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin người giám hộ");
                }
                else {
                    kh.HotenNguoigiamho = textBox_TenNguoiGiamHo.Text;
                    kh.Quanhe = textBox_MoiQuanHe.Text;
                    kh.SdtNgh = textBox_SDT_NGH.Text;
                }
            }
            else
            {
                kh.Ten = textBox_HoTen.Text;
                kh.Cmnd = textBox_CMND.Text;
                kh.NgaySinh = dateTimePicker_ngaySinh.Value;
                kh.Diachi = textBox_DiaChi.Text;
                kh.Sdt = textBox_SDT.Text;

                kh.GioiTinh = comboBox_GioiTinh.SelectedItem.ToString();
                if (this.kh.insertKhachHang(cnn, kh) == true)
                {
                    this.kh = kh;
                    // asking about register for vaccination
                    string message = "Đăng ký người dùng thành công. Đăng ký tiêm vacxin?";
                    string caption = "Đăng ký";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(this, message, caption, buttons,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign);

                    if (result == DialogResult.Yes)
                    {
                        if (_dangkytiem_tab == null)
                        {
                            this._dangkytiem_tab = new Dang_Ky_Tiem_Chung(cnn, this);
                        }
                        this._dangkytiem_tab.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công");
                }
                
            }

            

        }
        void DanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dataGridView1_DS_KhachHang.Columns["Xem"].Index) return;

            // Retrieve the user name.
            string user_name = dataGridView1_DS_KhachHang[1, e.RowIndex].Value.ToString();
            int id_kh = int.Parse(user_name);
            makh = id_kh;
            // Show user's infor tab
            this.Hide();
            this.kh.MaKH = user_name;
            this.kh.Ten = dataGridView1_DS_KhachHang[2, e.RowIndex].Value.ToString();
            this.kh.NgaySinh = DateTime.Parse(dataGridView1_DS_KhachHang[3, e.RowIndex].Value.ToString());
            this.kh.Sdt = dataGridView1_DS_KhachHang[4, e.RowIndex].Value.ToString();
            this.kh.Diachi = dataGridView1_DS_KhachHang[5, e.RowIndex].Value.ToString();
            if (_dangkytiem_tab == null)
            {
                this._dangkytiem_tab = new Dang_Ky_Tiem_Chung(cnn, this);
            }
            this._dangkytiem_tab.Show();

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            else
            {
                
                DataTable dt = this.kh.Timkiem(this.cnn, textBox_Search.Text);
                dataGridView1_DS_KhachHang.DataSource = dt;
            }    
        }

        private void dataGridView1_DS_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_DS_KhachHang.CellClick += new DataGridViewCellEventHandler(DanhSachKH_CellClick);

        }
    }
}

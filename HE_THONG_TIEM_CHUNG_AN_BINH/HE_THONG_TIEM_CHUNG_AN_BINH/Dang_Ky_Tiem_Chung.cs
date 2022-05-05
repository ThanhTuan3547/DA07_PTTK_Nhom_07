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
    public partial class Dang_Ky_Tiem_Chung : Form
    {
        private DataTable DataTable_ds_vacxin = new DataTable();
        private DataTable ds_vacxin_chon;
        public Dang_Ky_Tiem_Chung(SqlConnection cnn, Dang_ky_thong_tin_khach_hang DK)
        {
            
            InitializeComponent();
            label2.Text = "Mã khách hàng: " + DK.kh.MaKH;
            label1.Text = "Họ tên:" + DK.kh.Ten;
            label3.Text = "Ngày sinh: " + DK.kh.NgaySinh.Day +"/"+ DK.kh.NgaySinh.Month +"/"+  DK.kh.NgaySinh.Year;
            label4.Text = "Ngày đăng ký: " + DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year;

            // hien thi danh sach vacxin 
            Vacxin vxDAO = new Vacxin();

            //dataGridView1_DS_KhachHang.Columns[0].DataPropertyName = "Makh";
            dataGridView_DS_vacxin.Columns[0].DataPropertyName = "mavacxin";
            dataGridView_DS_vacxin.Columns[1].DataPropertyName = "TENVACXIN";
            dataGridView_DS_vacxin.Columns[2].DataPropertyName = "DONGIA";
            dataGridView_DS_vacxin.Columns[3].DataPropertyName = "tenncc";
            dataGridView_DS_vacxin.Columns[4].DataPropertyName = "THONGTINCHITIET";
            DataTable_ds_vacxin = vxDAO.timkiem(cnn, "");
            dataGridView_DS_vacxin.DataSource = DataTable_ds_vacxin;
            // setup danh sach vacxin duoc chon
            dataGridView1.Columns[0].DataPropertyName = "mavacxin";
            dataGridView1.Columns[1].DataPropertyName = "TENVACXIN";
            dataGridView1.Columns[2].DataPropertyName = "DONGIA";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> rows_with_checked_column = new List<string>();

            ds_vacxin_chon = DataTable_ds_vacxin.Clone();
            ds_vacxin_chon.Columns.Add("soluong");
            ds_vacxin_chon.Columns.Add("thanhtien");

            DataRow temp = new DataRow();
            foreach (DataGridViewRow row in dataGridView_DS_vacxin.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Chon"].Value) == true)
                {
                    //MessageBox.Show("OK!"); // Just to check if it understands I've checked the row
                    ds_vacxin_chon.ImportRow(DataTable_ds_vacxin.Rows[row.Index]);
                    //ds_vacxin_chon.Rows[row.Index]["soluong"] = 1;
                    //ds_vacxin_chon.Rows[row.Index]["thanhtien"] = DataTable_ds_vacxin.Rows[row.Index]["dongia"];
                    dataGridView1[row.Index, 3].Value = 1;
                    dataGridView1[row.Index, 4].Value = dataGridView1[row.Index, 2].Value;
                    //string value = row.Cells["USERNAME"].Value.ToString();
                    //rows_with_checked_column.Add(value);
                }

            }
            ds_vacxin_chon.Columns.Remove("tenncc");
            ds_vacxin_chon.Columns.Remove("thongtinchitiet");
            dataGridView1.DataSource = ds_vacxin_chon;
            
            //string[] List_userName_xoa = rows_with_checked_column.ToArray();
        }
    }
}

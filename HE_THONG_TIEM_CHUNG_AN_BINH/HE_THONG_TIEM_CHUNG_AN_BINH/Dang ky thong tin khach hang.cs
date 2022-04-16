using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    public partial class Dang_ky_thong_tin_khach_hang : Form
    {
        public Dang_ky_thong_tin_khach_hang()
        {
            InitializeComponent();
            DataGridViewButtonColumn btn_col = new DataGridViewButtonColumn();
            btn_col.Name = "Xem";
            btn_col.HeaderText = "Thông tin chi tiết";
            btn_col.Text = "Xem";
            dataGridView1_DS_KhachHang.Columns.Add(btn_col);
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
    }
}

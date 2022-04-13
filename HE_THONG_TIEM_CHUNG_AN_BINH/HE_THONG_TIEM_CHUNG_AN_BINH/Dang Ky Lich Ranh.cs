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
    public partial class Dang_Ky_Lich_Ranh : Form
    {
        public Dang_Ky_Lich_Ranh()
        {
            InitializeComponent();
            //them cot cho bang lich truc hien tai cua nhan vien 
            dataGridView_LichHienTai.Rows.Add("Sáng");
            dataGridView_LichHienTai.Rows.Add("Chiều");
            dataGridView_LichHienTai.Rows.Add("Tối");
            //them cot cho bang dang ky lich truc cua nhan vien 
            dataGridView_LichRanh.Rows.Add("Sáng");
            dataGridView_LichRanh.Rows.Add("Chiều");
            dataGridView_LichRanh.Rows.Add("Tối");
        }

        private void button_DangKyLich_Click(object sender, EventArgs e)
        {
            // dang ky lich ranh cua nhan vien

        }

        private void comboBox_TuanTruc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

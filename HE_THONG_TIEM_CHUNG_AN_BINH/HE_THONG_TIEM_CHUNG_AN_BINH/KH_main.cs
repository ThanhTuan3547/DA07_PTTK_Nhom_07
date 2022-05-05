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
    public partial class KH_main : Form
    {
        public KH_main()
        {
            InitializeComponent();
        }

        private void Info_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            KH_Info KH1 = new KH_Info();
            KH1.Show();
        }
    }
}

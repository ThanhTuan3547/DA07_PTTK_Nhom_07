using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HE_THONG_TIEM_CHUNG_AN_BINH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new dang_nhap());
            //Application.Run(new Dang_Ky_Lich_Ranh());
            //Application.Run(new Dang_ky_thong_tin_khach_hang());
            Application.Run(new DangKyMuaVacxin());
            //Application.Run(new Dang_Ky_Tiem_Chung());
        }
    }
}

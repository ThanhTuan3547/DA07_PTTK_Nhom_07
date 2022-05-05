using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HE_THONG_TIEM_CHUNG_AN_BINH
{

    public class KhachHang // Controller: class này chỉ thực hiện kiểm tra một số nghiệp vụ (vấn đề về dữ liệu trước khi đưa xuống class có đuôi DAO để lấy dữ liệu từ DB lên) (DAO: data access object)
    {

        string ten;
        string gioitinh;
        DateTime ngaysinh;
        string cmnd;
        string diachi;
        string sdt;
        string sdtNgh;
        string hotenNguoigiamho;
        string quanhe;
        string maKH;
        string taikhoan;
        string matkhau;

        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioitinh; set => gioitinh = value; }
        public DateTime NgaySinh { get => ngaysinh; set => ngaysinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string SdtNgh { get => sdtNgh; set => sdtNgh = value; }
        public string HotenNguoigiamho { get => hotenNguoigiamho; set => hotenNguoigiamho = value; }
        public string Quanhe { get => quanhe; set => quanhe = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }


        public KhachHang() // constructor
        {

        }

        public bool Loggin(SqlConnection cnn, int role, string taikhoan, string mkhau) // cái function này gọi xuống class KhachHangDAO(là class kết nối với DB)
        {

            KhachHangDAO login = new KhachHangDAO();

            if (login.login(cnn, role, taikhoan, mkhau) == true) {
                return true;
            }
            return false;
        }
        public bool CreateKhachHang(string ten, string gioitinh, string cmnd, string diachi, string sdt, string sdtNgh, string hotenNguoigiamho, string quanhe)
        {
            KhachHang khachhang = new KhachHang();
            KhachHangDAO KHDAO = new KhachHangDAO();
            // check sdt, cmnd 
            if (KHDAO.KhachHangTonTai(khachhang) == true)
            {
                return false;
            }
            else
            {
                khachhang.ten = ten;
                //khachhang.cmnd = cmnd;
                khachhang.sdt = sdt;
                khachhang.diachi = diachi;
            }
            return true;
        }
        public bool insertKhachHang(SqlConnection cnn, KhachHang kh)
        {// kiem tra thong tin khach hang da ton tai hay chua -> insert khach hang vao trong csdl

            KhachHangDAO khDAO = new KhachHangDAO();
            if (khDAO.KhachHangTonTai(kh) == false)
            {
                if (khDAO.insertKhachHang(cnn, kh) == true)
                    return true;
            }
            return false;
        }
        public DataTable Timkiem(SqlConnection cnn, string timkiem)
        {
            KhachHangDAO kh = new KhachHangDAO();
            return kh.timkiem(cnn, timkiem);
        }

    }

    public class Vacxin 
    {
        int mavacxin;
        string tenvacxin;
        int dongia;
        int nhacungcap;
        string thongtinchitiet;

        public Vacxin() { }
        public DataTable timkiem(SqlConnection cnn, string tenvacxin) {
            vacxinDAO vxDAO = new vacxinDAO();
            DataTable dt = vxDAO.timkiem(cnn, tenvacxin);
            return dt; 
        }
    }
    public class KhachHangDAO // class này để query từ DB
    {
        public bool KhachHangTonTai(KhachHang KH)
        {
            
            
            return false;// ko ton tai
        }
        public int CreateID(SqlConnection cnn,string table_name, string id_name)
        {
            string sqlstring = "select max(" + id_name + ") from " + table_name;
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int new_id = int.Parse(dt.Rows[0][0].ToString()) + 1;
            return new_id;
        }
        public bool insertKhachHang ( SqlConnection cnn, KhachHang KH)
        {
            cnn.Open();
            try
            {
                int Kh_id = CreateID(cnn, "KhachHang", "MaKH");
                string tk = "KH" + Kh_id;
                string ngaysinh = KH.NgaySinh.Year.ToString() + "-" + KH.NgaySinh.Month.ToString() + "-" + KH.NgaySinh.Day.ToString();
                //string sqlString = "insert into khachhang value ('" +Kh_id +"','" + KH.Ten + "''";
                string sqlstring = "INSERT dbo.KHACHHANG(MAKH, HOTENKH, NGAYSINH, SDT, DIACHI, TAIKHOAN, MATKHAU) VALUES("+Kh_id+", '"+KH.Ten+"', '"+ ngaysinh+"', '" + KH.Sdt+"', '" +KH.Diachi+ "', '"+tk+"', '12345')";
                SqlCommand cmd = new SqlCommand(sqlstring, cnn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            cnn.Close();
            return false;

        }
        public bool login(SqlConnection cnn,int role, string tk, string mk)
        {
            DataTable dt = new DataTable();
            if (role == 1) // khach hang
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM KHACHHANG WHERE TAIKHOAN ='"
                       + tk + "'" + " AND MATKHAU ='" + mk + "'", cnn);
                
                sda.Fill(dt);
            }
            if (role == 0) // nhan vien
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM  NHANVIEN WHERE TAIKHOAN ='"
                       + tk + "'" + " AND MATKHAU ='" + mk + "'", cnn);
                
                sda.Fill(dt);
            }
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            else
                return false;
            return false;
        }
        public DataTable timkiem(SqlConnection cnn, string thongtin) 
        {
            DataTable dt = new DataTable();
            string cmd = "select makh, hotenkh, ngaysinh, sdt, diachi from KhachHang where HotenKh like N'%" + thongtin + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(cmd,cnn);
            sda.Fill(dt);
            return dt;
        }
    }
    public class vacxinDAO
    {
        public DataTable timkiem(SqlConnection cnn, string tenvacxin)
        {
            cnn.Open();
            DataTable dt = new DataTable();
            string sqlstring = "select  mavacxin, tenvacxin, dongia, tenncc, thongtinchitiet from vacxin v join NHACUNGCAP n on v.nhacungcap = n.MANCC where tenvacxin like '%" + tenvacxin + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlstring, cnn);
            sda.Fill(dt);
            cnn.Close();

            return dt;
        }
    }
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
            Application.Run(new ConnectDB());
            //Application.Run(new Dang_Ky_Tiem_Chung());
        }
    }
}

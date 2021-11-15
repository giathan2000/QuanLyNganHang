using System;

namespace QuanLyNganHang.BO
{
    public class TaiKhoanBO 
    {
        private string strSoTaiKhoan;
        private string strCMND;
        private decimal decSoDu;
        private string strMaChiNhanh;
        private DateTime? dtmNgayMoTaiKhoan;


        public string SoTaiKhoan
        {
            set { strSoTaiKhoan = value; }
            get { return strSoTaiKhoan; }
        }
        public string CMND
        {
            set { strCMND = value; }
            get { return strCMND; }
        }
        public decimal SoDu
        {
            set { decSoDu = value; }
            get { return decSoDu; }
        }
        public string MaChiNhanh
        {
            set { strMaChiNhanh = value; }
            get { return strMaChiNhanh; }
        }
        public DateTime? NgayMoTaiKhoan
        {
            set { dtmNgayMoTaiKhoan = value; }
            get { return dtmNgayMoTaiKhoan; }
        }
    }

}
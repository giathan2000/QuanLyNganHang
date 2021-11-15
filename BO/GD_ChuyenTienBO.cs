using System;

namespace QuanLyNganHang.BO
{
    public class GD_ChuyenTienBO 
    {
        private int intMaGiaoDich;
        private string strSoTaiKhoanChuyen;
        private string strSoTaiKhoanNhan;
        private DateTime? dtmNgayGiaoDich;
        private decimal decSoTien;
        private string strMaNhanVien;

        public int MaGiaoDich
        {
            set { intMaGiaoDich = value; }
            get { return intMaGiaoDich; }
        }
        public string SoTaiKhoanChuyen
        {
            set { strSoTaiKhoanChuyen = value; }
            get { return strSoTaiKhoanChuyen; }
        }
        public string SoTaiKhoanNhan
        {
            set { strSoTaiKhoanNhan = value; }
            get { return strSoTaiKhoanNhan; }
        }
        public DateTime? NgayGiaoDich
        {
            set { dtmNgayGiaoDich = value; }
            get { return dtmNgayGiaoDich; }
        }
        public decimal SoTien
        {
            set { decSoTien = value; }
            get { return decSoTien; }
        }
        public string MaNhanVien
        {
            set { strMaNhanVien = value; }
            get { return strMaNhanVien; }
        }
    }

}
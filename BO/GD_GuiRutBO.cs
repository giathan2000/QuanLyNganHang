using System;

namespace QuanLyNganHang.BO
{
    public class GD_GuiRutBO 
    {
        private int intMaGiaoDich;
        private string strSoTaiKhoan;
        private string strLoaiGiaoDich;
        private DateTime? dtmNgayGiaoDich;
        private decimal decSoTien;
        private string strMaNhanVien;

        public int MaGiaoDich
        {
            set { intMaGiaoDich = value; }
            get { return intMaGiaoDich; }
        }
        public string SoTaiKhoan
        {
            set { strSoTaiKhoan = value; }
            get { return strSoTaiKhoan; }
        }

        /// <summary>
        /// GT: gởi tiền vào TK
        /// RT: rút tiền khỏi TK
        /// </summary>
        public string LoaiGiaoDich
        {
            set { strLoaiGiaoDich = value; }
            get { return strLoaiGiaoDich; }
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
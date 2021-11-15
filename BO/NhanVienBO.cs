using System;

namespace QuanLyNganHang.BO
{
    public class NhanVienBO 
    {
        private string strHo;
        private string strTen;
        private string strDiaChi;
        private string strMaNhanVien;
        private string strSoDienThoai;
        private string strPhai;
        private string strMaChiNhanh;
        private int intTrangThaiXoa = 0;

        public string Ho
        {
            set { strHo = value; }
            get { return strHo; }
        }
        public string Ten
        {
            set { strTen = value; }
            get { return strTen; }
        }
        public string DiaChi
        {
            set { strDiaChi = value; }
            get { return strDiaChi; }
        }
        public string MaNhanVien
        {
            set { strMaNhanVien = value; }
            get { return strMaNhanVien; }
        }
        public string SoDienThoai
        {
            set { strSoDienThoai = value; }
            get { return strSoDienThoai; }
        }

        /// <summary>
        /// ‘Nam’ hoặc ‘Nữ’
        /// </summary>
        public string Phai
        {
            set { strPhai = value; }
            get { return strPhai; }
        }
        public string MaChiNhanh
        {
            set { strMaChiNhanh = value; }
            get { return strMaChiNhanh; }
        }
        public int TrangThaiXoa
        {
            set { intTrangThaiXoa = value; }
            get { return intTrangThaiXoa; }
        }
    }

}
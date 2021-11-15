using System;

namespace QuanLyNganHang.BO
{
    public class KhachHangBO 
    {
        private string strHo;
        private string strTen;
        private string strDiaChi;
        private string strCMND;
        private DateTime? dtmNgayCap;
        private string strSoDienThoai;
        private string strPhai;
        private string strMaChiNhanh;

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
        public string CMND
        {
            set { strCMND = value; }
            get { return strCMND; }
        }
        public DateTime? NgayCap
        {
            set { dtmNgayCap = value; }
            get { return dtmNgayCap; }
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

    }

}
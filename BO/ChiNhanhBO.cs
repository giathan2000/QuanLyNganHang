using System;

namespace QuanLyNganHang.BO
{
    public class ChiNhanhBO
    {
        private string strMaChiNhanh;
        private string strTenChiNhanh;
        private string strDiaChi;
        private string strSoDienThoai;

        public string MaChiNhanh
        {
            set { strMaChiNhanh = value; }
            get { return strMaChiNhanh; }
        }

        public string TenChiNhanh
        {
            set { strTenChiNhanh = value; }
            get { return strTenChiNhanh; }
        }

        public string DiaChi
        {
            set { strDiaChi = value; }
            get { return strDiaChi; }
        }

        public string DienThoai
        {
            set { strSoDienThoai = value; }
            get { return strSoDienThoai; }
        }

    }

}
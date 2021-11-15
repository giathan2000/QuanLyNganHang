using DevExpress.Xpo;
using System;

namespace QuanLyNganHang.BO
{
    public class NhanVien : XPObject
    {
        public NhanVien() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public NhanVien(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}
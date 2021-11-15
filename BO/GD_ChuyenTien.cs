using DevExpress.Xpo;
using System;

namespace QuanLyNganHang.BO
{
    public class GD_ChuyenTien : XPObject
    {
        public GD_ChuyenTien() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public GD_ChuyenTien(Session session) : base(session)
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
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_6_BAI_MAU_CRUD_OBJ
{
    internal class NguoiYeuMoi:Nguoi
    {
        private double canNang;
        private string soThich;
        private string danhGia;
        public NguoiYeuMoi()
        {
            
        }

        public NguoiYeuMoi(string ten, string sdt, int gioiTinh, double canNang, string soThich) : base(ten, sdt, gioiTinh)
        {
            this.canNang = canNang;
            this.soThich = soThich;
        }

        public double CanNang
        {
            get => canNang;
            set => canNang = value;
        }

        public string SoThich
        {
            get => soThich;
            set => soThich = value;
        }

        public string DanhGia
        {
            get => canNang<=50?"Gầy": canNang <= 80 ? "Đẹp":"Đáng yêu";
            //set => danhGia = value;
            //Đánh giá sẽ không thể gán giá trị từ bên ngoài
        }

        public override void inRaManHinh()
        {
            Console.WriteLine($"{Ten} | {Sdt} | {(GioiTinh==1?"Nam":"Nữ")} | {soThich} | {canNang} | [{DanhGia}]");
        }
    }
}

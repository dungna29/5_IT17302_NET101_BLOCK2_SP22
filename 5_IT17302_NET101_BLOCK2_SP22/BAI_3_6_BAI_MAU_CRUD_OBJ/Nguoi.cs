using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_6_BAI_MAU_CRUD_OBJ
{
    internal class Nguoi
    {
        private string ten;
        private string sdt;
        private int gioiTinh;//1 = Nam | 0 Nữ

        public Nguoi()
        {
            
        }

        public Nguoi(string ten, string sdt, int gioiTinh)
        {
            this.ten = ten;
            this.sdt = sdt;
            this.gioiTinh = gioiTinh;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public int GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public virtual void inRaManHinh()
        {

        }
    }
}

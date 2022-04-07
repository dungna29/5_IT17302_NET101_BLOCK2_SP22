using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_4_0_AccessModifier
{
    internal class Program
    {
        /*
         * AccessModifier: sử dụng trên biến, phương thức
         * Public: Được phép truy cập ở tất cả các lớp
         * Private: Chỉ được phép sử dụng bên trong class đó.
         * Protected: Chỉ cho phép lớp con mới có quyền truy cập và trong cùng 1 class vẫn truy cập.
         * Internal: Chỉ được truy cập bên trong 1 thư mục.
         *
         * Ngoài ra còn 2 sự kết hợp: protected internal, private protected
         */
        class SinhVien
        {
            private string att1;//private
            public string att2;
            string att3;//= private
            internal string att4;
            protected string att5;
        }

        class SinhVienUD:SinhVien
        {
            public SinhVienUD()
            {
                att5 = " ";
            }
        }
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            //sv.att1 = " ;
            sv.att2 = " ";
            sv.att4 =" ";
            //sv.att5 = " ";
        }
    }
}

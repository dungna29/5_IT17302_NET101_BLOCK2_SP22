using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_5_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Khi kế thừa thì lớp con có đầy đủ các thuộc tính và phương của lớp cha cho phép.
             * 2. Khi sử dụng contructor lớp con sẽ vẫn đầy đủ các thuộc tính mà nó được kế thừa.
             */
            SinhVien sv1 = new SinhVien();
            sv1.Ten = "Dũng";
            sv1.Sdt = "012345";
            sv1.Msv = "PH123";
            //.....
            SinhVien sv2 = new SinhVien("Văn A", "2000", "098", "001", "12/12/200", "@fpt", "12 Lạc long quân", "ph123",
                "UDPM C#");

            //Ghi đè phương thức
            Nguoi n1 = new Nguoi();
            n1.method2();
            SinhVien sv3 = new SinhVien();
            sv3.method2();

        }
    }
}

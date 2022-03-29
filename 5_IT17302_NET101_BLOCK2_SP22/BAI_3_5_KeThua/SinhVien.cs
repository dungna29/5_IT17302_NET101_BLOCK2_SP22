using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_5_KeThua
{
    /*
     * 1. Để sử dụng kế thừa dùng dấu :
     * 2. Trong C# và JAVA chỉ cho phép đơn kế thừa
     */
    internal class SinhVien : Nguoi//Sinh viên sẽ là lớp con
    {
        //Lớp con chỉ cần khai báo các thuộc tính đặc trưng riêng của mình
        private string msv;
        private string nganhhoc;

        public SinhVien()
        {

        }
        //Tạo contructor có tham số
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Contructor 'ClassCon(Bên trong có tham số của thuộc tính cha)
        //3. Bôi vào các thuộc tính của con -> Quick Actions -> Add Parameter to contructor -> Chọn cái contructor có tham số vừa Generate ra.
        public SinhVien(string ten, string ns, string sdt, string cccd, string ngaySinh, string email, string diaChi, string msv, string nganhhoc) : base(ten, ns, sdt, cccd, ngaySinh, email, diaChi)
        {
            this.msv = msv;
            this.nganhhoc = nganhhoc;

            //this: Dùng để tham chiếu thuộc tính và phương thức của lớp hiện tại
            //base: Dùng để tham chiếu thuộc tính và phương thức của lớp cha
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string Nganhhoc
        {
            get => nganhhoc;
            set => nganhhoc = value;
        }
        //Muốn kế thừa phương thức của lớp cha
        //1. Chuột phải vào tên Class Con ở trên -> Quick Actions
        //2. Generate Overrides sau đó chọn phương thức các bạn muốn kế thừa
        //3. Khi kế thừa lại phương thức của lớp cha thì phương thức đặt tại lớp con có thể code lại nội dung bên trong thì hành động này gọi là ghi đè phương thức.

        //override ghi đè phương thức
        public override int method1(int a, int b)
        {
            //Khi đã kế thừa phương thức lớp con có thể toàn quyền code lại nội dung bên trong phương thức.
            return base.method1(a, b);
        }

        public override void method2()
        {
            Console.WriteLine("Đây là phương thức lớp con đã edit");
        }
    }
}

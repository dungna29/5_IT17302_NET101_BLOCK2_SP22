using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_1_OOP
{
    //class = lớp
    //SinhVien = đối tượng muốn quản lý
    //Đối tượng phải viết hoa chữ cái đầu của từ là bắt buốc.
    internal class SinhVien
    {
        //Phần 1: Khai báo tất cả các thuộc tính mà đối tượng cần
        private string ten;
        private string msv;
        private string queQuan;
        private int ns;
        private int gioiTinh;//1 = Nam | 0 Nữ
        string truongHoc = "FPOLY";

        //Phần 2: Contructor - Hàm tạo
        /*
         * 1 - Contructor giống với tên đối tượng
         * 2 - Contructor là thành phần được chạy vào đầu tiên khi khởi tạo đối tượng.
         * 3 - Khi mới học mỗi đối tượng luôn có 2 Contructor 1 là có tham số 2 là không tham số.
         * 4 - Khi lớp đối tượng không có Conctructor thì khi khởi tạo bên ngoài sẽ tự động tạo ra 1 contructor không tham số mặc định.
         */
        //Contructor không tham số - ctor + tab
        public SinhVien()
        {
            Console.WriteLine("Chay vao contructor khong tham so");
        }
        //Contrcutor có tham số giúp gán giá trị cho thuộc tính ngay khi khởi tạo đối tượng
        /*
       Nếu bạn nào dùng resharper ctorf + tab
       Đối với các bạn không cài resharper muốn gọi contructor có tham số:
          1. Chuột phải vào Class đối tượng chọn Quick Actions....
          2. Generate Contructor và bấm ok
       */
        public SinhVien(string ten1, string msv, string queQuan, int ns, int gioiTinh, string truongHoc)
        {
            ten = ten1;
            this.msv = msv;
            this.queQuan = queQuan;
            this.ns = ns;
            this.gioiTinh = gioiTinh;
            this.truongHoc = truongHoc;
            //this: Dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
        }
        //Phần 3: Triển khai property của thuộc tính vì các thuộc tính bị private không thể truy cập trự tiếp
        /*
         * Bôi đen vào các thuộc tính đang có hiện tại của lớp sau đó chuột phải --> Quick Actions....
         * Chọn Encapsulate fields
         *
         */
        //public TYPE Type { get; set; } prop + tab
        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public int GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }

        public string TruongHoc
        {
            get => truongHoc;
            set => truongHoc = value;
        }

        //Phần 4: Các phương thức của đối tượng
        public void inRaManHinh()
        {
            Console.WriteLine($"{ten} | {msv} | {(gioiTinh ==1 ?"Nam":"Nữ")} | {truongHoc} | {queQuan}");
        }
    }
}

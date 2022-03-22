using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_1_OOP
{
    internal class Program
    {
        /*
   LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG OOP
   1. Định nghĩa:
      Lập trình hướng đối tượng (Object Oriented Programing – OOP) là đưa các đối tượng có trong thế giới thực (Sinh Viên, ô tô, chó, mèo, người, hoa......) vào trong lập trình để thao tác với các Đối Tượng(thêm,sửa,xóa....) hoặc với các THUỘC TÍNH của đối tượng.
   2. 4 Tính chất của OOP:
    + Đa hình (Polymorphism): Nó thể hiện rõ nhất khi gọi đến một phương thức của đối tượng giống nhau nhưng kết quả của phương thức đó có thể khác nhau.
        - Nạp chồng (Overloading): Nạp chồng phương thức cùng tên cùng kiểu phương thức nhưng khác tham số truyền vào. Khi đưa đúng số lượng tham số truyền vào sẽ gọi đúng phương thức cần được thực hiện.
        - Ghi đè (Overriding): Ghi đè phương thức có cùng tên cùng tham số giữa lớp cha và lớp con. Các phương thức của lớp con kế thừa từ lớp cha từ kiểu phương thức, tên, tham số truyền vào nhưng tại các lớp con có thể viết lại code hành động khác theo nghiệp vụ của nó với phương thức được kế thừa.
    + Thừa kế (Inheritance): Cho phép định nghĩa một lớp đối tượng dựa trên các thuộc tính có sẵn của một lớp đã có. Trong C# chỉ có đơn kế thừa không có đa kế thừa - 1 con chỉ có 1 cha
    + Đóng gói (Encapsulation):Tức là trạng thái của đối tượng được bảo vệ không cho các truy cập từ code bên ngoài như thay đổi trong thái hay nhìn trực tiếp. Việc cho phép môi trường bên ngoài tác động lên các dữ liệu nội tại của một đối tượng theo cách nào là hoàn toàn tùy thuộc vào người viết mã. Đây là tính chất đảm bảo sự toàn vẹn, bảo mật của đối tượng Trong Java, tính đóng gói được thể hiện thông qua phạm vi truy cập (access modifier). Ngoài ra, các lớp liên quan đến nhau có thể được gom chung lại thành package.
            - Có hai loại modifier trong: access modifiers và non-access modifiers.
                * Có 4 kiểu của java access modifiers:
                    - private
                    - (Mặc định)
                    - protected
                    - public
                * non-access modifiers chẳng hạn static, abstract, synchronized, native, volatile, transient, v.v..
    + Trừu tượng (Abstraction): Trừu tượng có nghĩ là tổng quát hóa một cái gì đó lên. không cần chú ý chi tiết bên trong.
        - Tính trừu tượng là một tiến trình ẩn các chi tiết trình triển khai và chỉ hiển thị tính năng tới người dùng. Tính trừu tượng cho phép bạn loại bỏ tính chất phức tạp của đối tượng bằng cách chỉ đưa ra các thuộc tính và phương thức cần thiết của đối tượng trong lập trình.
        - Tính trừu tượng giúp bạn tập trung vào những cốt lõi cần thiết của đối tượng thay vì quan tâm đến cách nó thực hiện.
        - Trong C#, chúng là sử dụng abstract class và abstract interface để có tính trừu tượng.
        3. Khái niệm
            - Class: Chúng ta có thể xem lớp như một khuôn mẫu (template) của đối tượng (Object). Trong đó bao gồm dữ liệu của đối tượng (fields hay properties) và các phương thức(methods) tác động lên thành phần dữ liệu đó gọi là các phương thức của lớp. Class là từ khóa để khai báo lớp. 
            - Đối tượng (Object): được xem là một thực thể trong thế giới thực.
            - Object bao gồm: Thuộc tính (Attribute/Method)
            - Attribute: Các thuộc tính của đối tượng
            - Phương thức:  Phương thức hay còn gọi là hàm thành viên Một phương thức là một nhóm lệnh cùng nhau thực hiện một tác vụ
            - Từ khóa this trong C# là một biến tham chiếu được sử dụng để tham chiếu tới đối tượng của lớp hiện tại.
     */
        /*
         * 1. Đối tượng là:Ban, Ghế, Bút, Vở, Máy tính, Chuột, Bàn phím, Quạt, Máy chiếu, Điện Thoại,Thực vật, Hoa, Cây, Người, Sinh Viên, Giảng Viên, Bảo Vệ.........(Phải là Danh Từ)
         *  - Thông tin đối tượng: Mầu sắc, kích thước, trọng lượng,....... Miêu tả cho đối tượng rõ hơn.
         *  - Hành đồng đối tượng: Sinh Viên (Làm bài, đi học, đi chơi, ngủ...)
         *
         * Vậy trong lập trình
         *  1. Đối tượng: Biểu diễn với từ khóa Class - Lớp. (Danh Từ Viết hoa chữ cái đầu của từ.)
         *  2. Thông tin đối tượng: Thay thế cách gọi là khác là THUỘC TÍNH. Thuộc tính trong lập trình được biểu diễn dưới dạng khai báo biến.
         *  3. Hành động đối tượng: Được biểu diễn dưới dạng phương thức method và luôn là động từ đứng trước.
         */
        static void Main(string[] args)
        {
            /*
             * Sinh viên 1:
             * Tên: Huyền
             * Msv: PH123
             * Quê Quán: HN
             * Năm Sinh: 2002
             *
             * * Sinh viên 2:
             * Tên: Quang
             * Msv: PH124
             * Quê Quán: Bắc Ninh
             * Năm Sinh: 2004
             */
            //Phần 1: Tạo lớp, sử dụng đối tượng cần biết tên lớp và nơi lưu
            SinhVien sv1;//Khai báo 1 đối tượng và có kiểu dữ liệu SinhVien
            sv1 = new SinhVien();//Phải khởi tạo đối tượng thì mới sử dụng được

            SinhVien sv2 = new SinhVien("Quang", "PH124", "BN", 2003, 1, "BK");//Khởi tạo 1 đối tượng bằng contructor có tham số

            //In 2 đối tượng trên
            sv1.inRaManHinh();//Đối tượng 1 không có giá trị
            sv2.inRaManHinh();//Đối tượng 2 có giá trị ngay khi khởi tạo

            //Phần 2: Gán giá trị cho thuộc tính của đối tượng thông qua việc chấm các property hoặc contructor có tham số
            sv1.Ten = "Huyền";
            sv1.Msv = "PH123";
            sv1.GioiTinh = 0;
            sv1.QueQuan = "HN";
            sv1.TruongHoc = "FPOLY HN";
            sv1.inRaManHinh();

            //In 1 vài giá trị trong đối tượng
            Console.WriteLine(sv1.Ten);//In chỉ 1 mình tên ra màn hình

        }
    }
}

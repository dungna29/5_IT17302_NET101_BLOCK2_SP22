using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_3_List
{
    internal class Program
    {
        /*
         *  LIST trong C# Generic Collections nó dùng lưu trữ giống như ArrayList vê khái niệm.
         *
         *  1.Khai báo:
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>();
         *      List<Kiểu dữ liệu> lst + Tên =  new List<Kiểu dữ liệu>(size);//Khai báo kích thước định sẵn
         */

        /*
         * A. CÁC PHƯƠNG THỨC TRONG List
         * 1. Add(object Value): Thêm đối tượng vào cuối.
         * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
         * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
         * 4. Clear(): Xóa tất cả các phần tử.
         * 5. Clone(): Tạo 1 bản sao của danh sách đó.
         * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
         * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
         * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
         *9.CopyTo(<tên mảng>,<index>): Thực hiện sao chép các phần tử List về mảng 1 chiều từ index của mảng
         * 10. Remove(<value>): Xóa value ở trong List
         *
         * Ngoài ra còn có thêm 1 số phương thức khác
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Khai báo và khởi tạo
            List<string> lstNames;//Khai báo
            lstNames = new List<string>();//Khởi tạo nó

            List<int> lstint = new List<int>(5);//Khởi tạo có kích thước
            List<double> lstdouble = new List<double>();

            List<SinhVien> lstSinhViens = new List<SinhVien>();//Khởi tạo 1 List có kiểu dữ liệu là đối tượng

            //Phần 2: Thêm phần tử sử dụng phương thức add() và phải truyền đúng kiểu dữ liệu
            lstNames.Add("C#1");
            lstNames.Add("C#2");
            lstNames.Add("C#3");
            lstNames.Add("C#4");
            lstNames.Add("C#5");

            //Phần 3: Muốn truy xuất giá tị thì phải index
            Console.WriteLine(lstNames[2]);//C#3
            for (int i = 0; i < lstNames.Count; i++)
            {
                Console.Write(lstNames[i] + " ");
            }
            //foreach tương tự

            //Phần 4: Một vài phương thức hay sử dụng
            lstNames.RemoveAt(4);//Xóa phần tử có giá trị C#5
            lstNames.Clear();//Xóa các phần tử trong List
            lstNames = new List<string>();//Khởi tạo nhưng cũng làm trắng danh sách.
        }
    }
}



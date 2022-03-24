using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_2_ArrayList
{
    internal class Program
    {/*
         *  ArrayList
         *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                        danh sách các đối tượng theo kiểu mảng (truy
                        cập các phần tử bên trong thông qua chỉ số
                        index)
            Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                        linh hoạt và có thể tự điều chỉnh kích cỡ một
                        cách tự động.
            Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                        thêm thư viện System.Collections
            Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
         */

        /*
          * A. CÁC PHƯƠNG THỨC TRONG ArrayList
          * 1. Add(object Value): Thêm đối tượng vào cuối.
          * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
          * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
          * 4. Clear(): Xóa tất cả các phần tử.
          * 5. Clone(): Tạo 1 bản sao của danh sách đó.
          * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
          * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
          * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
          */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Phần 1: Khởi tạo và khai báo ArrayList không định kiểu
            ArrayList arrLstKhongDinhKieu;//Khai báo
            arrLstKhongDinhKieu = new ArrayList();//Khởi tạo thì mới sử dụng được

            //Phần 2: Gán giá trị thông qua phương thức add()
            arrLstKhongDinhKieu.Add(1);
            arrLstKhongDinhKieu.Add("C#1");
            arrLstKhongDinhKieu.Add(true);
            arrLstKhongDinhKieu.Add('a');
            arrLstKhongDinhKieu.Add(8.9);

            //Phần 3: Xuất giá trị cũng bắt đầu từ 0
            Console.WriteLine(arrLstKhongDinhKieu[0]);//Index bắt đầu từ 0
            //arrLstKhongDinhKieu.Count = Kích thước của mảng
            for (int i = 0; i < arrLstKhongDinhKieu.Count; i++)
            {
                Console.Write(arrLstKhongDinhKieu[i] + " ");
            }

            Console.WriteLine();
            foreach (var x in arrLstKhongDinhKieu)
            {
                Console.Write(x + " ");
            }

            //Phần 4: Một vài phương thức
            arrLstKhongDinhKieu.RemoveAt(4);//Xóa phần tử chỉ định theo index
            arrLstKhongDinhKieu.Clear();//Xóa toàn bộ các phần tử
            arrLstKhongDinhKieu = new ArrayList();//Khởi tạo đồng nghĩa cũng làm rỗng ArrayList
        }
    }
}

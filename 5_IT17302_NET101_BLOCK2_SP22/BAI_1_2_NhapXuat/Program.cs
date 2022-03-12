using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_NhapXuat
{
    internal class Program
    {/*
         * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Phím tắt : cw + tab
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
         *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //In ra màn hình
            Console.WriteLine("Chào các bạn đến với C#1");
            Console.Write("năm 2022");
            Console.WriteLine("Block 2");

            //Nhập năm sinh vào và in ra
            //Bước 1: Xác định được bài toán cần bao nhiêu biến
            int ns;

            //Bước 2: Đổ dữ liệu vào các biến nếu cần
            Console.WriteLine("Mời bạn nhập năm sinh: ");
            ns = Convert.ToInt32(Console.ReadLine());//Phải ép về đúng kiểu thì mới gán giá trị cho ns được

            //Bước 3: Thực thi hoặc xử lý nghiệp vụ
            Console.WriteLine($"Tuổi bạn vừa nhập vào: {2022-ns}");
        }
    }
}

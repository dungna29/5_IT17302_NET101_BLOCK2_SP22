using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_0_ThaoTacVoiMang
{
    internal class Program
    {
        /*
        * Bài 2.6 Thao tác với mảng
        *  - 1. Phương thức của Array
        *      + SetValue(<giá trị>,<index>): Gán giá trị cho phần tử ở vị trí.
        *      + GetValue(index): lấy giá trị ở vị trí
        *      + IndexOf(<Array>,<value>): Tìm kiếm vị trí của phần tử
        *      + GetLength(0): Trả ra số lượng phần tử trong mảng
        *      + Reverse(<mảng>): Đảo ngược mảng
        *      + Sort(Array): Sắp xếp mảng
        
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string[] arrNames = {"B", "D", "E", "F", "A"};
            //In mảng
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            //1. Sort sử dụng thư viện có sẵn
            Console.WriteLine("Sắp xếp mảng");
            Array.Sort(arrNames);//Sắp xếp tăng dần
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            //2. Reverse
            Console.WriteLine("Sắp xếp mảng");
            Array.Reverse(arrNames);//Đảo ngược danh sách
            foreach (var x in arrNames)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

        }
    }
}

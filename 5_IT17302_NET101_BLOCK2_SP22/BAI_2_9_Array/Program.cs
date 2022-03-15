using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2_9_Array
{
    internal class Program
    {
        /*
        * Phần 1: Mảng 1 chiều
        *
        *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
        *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
        *
        *  2. Khai báo 1 mảng trong Csharp:
        *          - Cách 1:
        *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
        *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
        *          - Cách 2: 
        *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
        *
        *          - Cách 3:
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
        *
        *     <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm đinhj
        *
        *  3. Truy xuất các phần tử trong mảng
        *      - Gán giá trị cho mảng:
        *           <tên mảng>[index] = Giá trị cần gán.
        *   
        *     - Lấy giá trị trong mảng:
        *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
        *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
        *
        *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính length.
        *      <tên mảng>.length = kích thước mảng có kiểu số nguyên
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //1. Khai báo biến
            int a = 5;

            //2. Khai báo 2 mảng
            int[] arrNumbers;//Khai báo mảng
            arrNumbers = new int[5];//Khởi tạo 1 mảng có 5 phần tử

            string[] arrNames = new string[6];//Khởi tạo mảng gồm 5 phần tử

            string[] arrMonhoc = new string[] {"C#1","C#2","C#3"};//Khởi tạo kiểu tường minh
            string[] arrMonhoc1 = new [] {"C#1","C#2","C#3"};//Khai báo kiểu ngầm định

            var arrNumbers1 = new[] {1, 2, 3, 4, 5};//Hiểu mảng nguyên
            var arrNumbers2 = new int[] {1, 2, 3, 4, 5};//Hiểu mảng nguyên

            //3. Gán giá trị trong mảng cần biết  index
            arrNumbers[0] = 8;//Gán giá trị cho index 0
            arrNumbers[1] = 88;
            arrNumbers[2] = 89;
            arrNumbers[0] = 99;//Ghi đè giá trị tại index 0

            //4. Lấy giá trị
            //Lấy giá trị đơn
            Console.WriteLine(arrNumbers[0]);

            //Xuất cả mảng
            foreach (var x in arrNumbers)
            {
                Console.Write(x + " ");// 7 8 9 0
            }

            Console.WriteLine();
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.Write(arrNumbers[i] + " ");
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CHUA_BAI_LAB_123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bai0();
        }

        static void Bai0()
        {
            int batdau, ketthuc;//Biến cục bộ
            Console.WriteLine("Mời bạn nhập vào khoảng 1: ");
            batdau = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập vào khoảng 2: ");
            ketthuc = Convert.ToInt32(Console.ReadLine());
            //Cách 1: Sử dụng thuật toán hoán vị
            // if (batdau > ketthuc)
            // {
            //     int temp = batdau;
            //     batdau = ketthuc;
            //     ketthuc = temp;
            // }
            for (int i = Math.Min(batdau, ketthuc); i < Math.Max(batdau, ketthuc); i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }

        static void bai1()
        {
            int[] arrNumber;//Khai báo mảng
            int size;
            Console.WriteLine("Mời bạn nhập kích thước mảng: ");
            size = Convert.ToInt32(Console.ReadLine());//Lấy được kích thước mảng
            //Phải khởi tạo mảng
            arrNumber = new int[size];
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.Write($"Mời bạn nhập phần tử thứ {i}: ");
                arrNumber[i] = Convert.ToInt32(Console.ReadLine());//Nhập giá trị cho phần tử trong mảng
            }

            foreach (var x in arrNumber)
            {
                Console.Write((x % 2 == 0 ? Convert.ToString(x) : "") + " ");
            }

            Console.WriteLine();
            foreach (var x in arrNumber)
            {
                Console.Write((x % 2 != 0 ? Convert.ToString(x) : "") + " ");
            }
        }

        static void Bai3()
        {
            string[] arrSinhViens;
            int size,ns;
            string ten, msv;
            Console.Write("Mời bạn nhập số lượng: ");
            size = Convert.ToInt32(Console.ReadLine());
            arrSinhViens = new string[size];
            for (int i = 0; i < arrSinhViens.Length; i++)
            {
                Console.Write("Mời bạn nhập tên: ");
                ten = Console.ReadLine();
                Console.Write("Mời bạn nhập ns: ");
                ns = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập msv: ");
                msv = Console.ReadLine();
                arrSinhViens[i] = ten + "         " + ns + "    " + (2022 - ns) + "    " + msv;

            }
            //Cách chưa thực sự tốt khi in ra
            Console.WriteLine("Tên         NS    Tuổi    Msv");
            foreach (var x in arrSinhViens)
            {
                Console.WriteLine(x);
            }
        }
    }
}

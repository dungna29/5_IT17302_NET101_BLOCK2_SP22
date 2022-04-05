using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_8_ThuatToanNoiBot_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumber = {7, 4, 3, 2};
            /*
             * Để học giải thuật cần có 2 hướng để học.
             * 1. Dùng giấy bút, word, exel... ghi các bước thực hiện.
             * 2. Sử dụng câu lệnh in để in các bước thực hiện ra.
             *
             * Cách 1:
             *  7 4 3 2
             * i = 0 j = 1 | arr[0] > arr[1] | 7 > 4 = true
             *  4 7 3 2
                i = 0 j = 2 | arr[0] > arr[2] | 4 > 3 = true
                3 7 4 2
                i = 0 j = 3 | arr[0] > arr[3] | 3 > 2 = true
                2 7 4 3
                
                i = 1
                i = 1 j = 2 | arr[1] > arr[2] | 7 > 4 = true
                2 4 7 3
                i = 0 j = 3 | arr[1] > arr[3] | 4 > 3 = true
                2 3 7 4

                i = 2
                i = 2 j = 3 | arr[2] > arr[3] | 7 > 4 = true
                2 3 4 7
                
                i = 3 sẽ không chạy vì length - 1
            */
            // for (int i = 0; i < arrNumber.Length-1; i++)
            // {
            //     for (int j = i + 1; j < arrNumber.Length; j--)
            //     {
            //         if (arrNumber[i]> arrNumber[j])
            //         {
            //             int temp = arrNumber[i];
            //             arrNumber[i] = arrNumber[j];
            //             arrNumber[j] = temp;
            //         }
            //     }
            // }
            for (int i = 0; i < arrNumber.Length - 1; i++)
            {
                Console.WriteLine("Lần chay thứ: " + i);
                foreach (var x in arrNumber)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine("");
                for (int j = i + 1; j < arrNumber.Length; j++)
                {
                    Console.Write("Điều kiện {0} > {1} \n", arrNumber[i], arrNumber[j]);
                    if (arrNumber[i] > arrNumber[j])
                    {
                        int temp = arrNumber[i];
                        arrNumber[i] = arrNumber[j];
                        arrNumber[j] = temp;
                        Console.Write("Hoán vị của:{0} & {1} \n", arrNumber[i], arrNumber[j]);
                        foreach (int x in arrNumber)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine("");
                    }
                }
            }

            foreach (var x in arrNumber)
            {
                Console.Write(x + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_7_Switch_Case
{
    internal class Program
    {
        
        /*
         * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
         *
         * Công thức: sw + tab
         *
         *  switch (<Biểu thức>)
            {
                case <giá trị 1>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break; 
                case <giá trị 2>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                .......
                case <giá trị n>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                default:
                    Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                    break;
            }
         */
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Menu ăn sáng");
                Console.WriteLine("1. Phở bò");
                Console.WriteLine("2. Bún bò");
                Console.WriteLine("3. Cơm bò");
                Console.WriteLine("4. Thoát");
                Console.Write("Mời bạn chọn món: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Phở");
                        break;
                    case "2":
                        Console.WriteLine("Bún");
                        break;
                    case "3":
                        Console.WriteLine("Cơm");
                        break;
                    case "4":
                        Console.WriteLine("Hẹn gặp lại");
                        //Cách 2:
                        //Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Món ăn không tồn tại");
                        break;
                }
            } while (!(input == "4"));//4=4true

        }
    }
}

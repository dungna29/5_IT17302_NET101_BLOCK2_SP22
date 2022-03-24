using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_4_Method
{
    internal class MethodVoid
    {
        /*
         *  Phương thức không trả về là : Void
         *   Công thức chung:
         *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
         *  {
         *          Body code
         *  }
         */
        //Phương thức không trả về và không tham số
        public void tinhTong2So()
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a+b}");
        }

        //Phương thức không trả về nhưng có tham số
        public void tinhTong()//Không trả về ko tham số
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        // public void tinhTong()//Trùng tên phương thức trong 1 class
        // {
        //     
        // }
        //(int a, int b) = tham số truyền vào

        //Phương thức trùng tên nhưng phải khác tham số được gọi là nạp chồng phương thức (Overloading) trong tính đa hình OOP
        public void tinhTong(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void tinhTong(int a, int b,int c)
        {
            //Console.WriteLine($"{a} + {b} + {c}= {a + b + c}");
            Console.WriteLine("Tôi chưa code xong");
        }
        public void tinhTong(int a, int b,string c)
        {
            Console.WriteLine($"{a} + {b} + {c}= {a + b + c}");
        }
        //Lưu ý: Tham số có thể là những kiểu dữ liệu khác nhau
        public void method1(int a, int[] arr,ArrayList arrLst,List<int> lstint)
        {

        }
    }
}

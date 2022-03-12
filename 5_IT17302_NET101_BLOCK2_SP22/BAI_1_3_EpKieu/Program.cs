using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_3_EpKieu
{
    internal class Program
    {
        /*
      * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
      *
      * Công thức ép kiểu tường minh:
      *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
      *
      * P2: Ép kiểu từ string về số
      *  + Phương thức Parse()
      *  + Lớp Convert()
      */
        static void Main(string[] args)
        {
            //Hỗ trợ hiển thị tiếng việt
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string a, b;
            Console.WriteLine("Mời bạn nhập số a: ");
            a = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập số b: ");
            b= Console.ReadLine();
            Console.WriteLine($" a + b = {a + b}");//? Có thực hiện được phép cộng không?

            //Ở trên không thể thực hiện phép toán với 2 chuỗi vì nó sẽ là hành động cộng chuỗi hoặc nối chuỗi.

            //Cách 1: Ép kiểu String về số sử dụng Convert
            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine($" a + b = {c}");

            //Cách 2: Ép kiểu với parse
            int d = int.Parse(a) + int.Parse(b);
            Console.WriteLine($" a + b = {d}");

            //Ngoài ra 1 vài ví dụ:
            double d1 = double.Parse("7.9");

            //Phần 2: Chuyển đổi kiểu dữ liệu số với nhau
            int n1 = 9;
            double n2 = 8.9;
            n2 = n1;//Ép kiểu tự động
            //n1 = n2; Không thể gán giá trị của biến n2 cho n1 vì kích thước kiểu dữ liệu double lớn hơn int
            n1 = (int) n2;//Nó sẽ loại bỏ toàn bộ phần thập phân
        }
    }
}

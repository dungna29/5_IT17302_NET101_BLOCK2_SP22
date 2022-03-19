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

            /*
             *     Baì 0: In bảng cửu chương theo khoảng mà người dùng nhập vào.
                 * Bài 1: Viết 1 chương trình cho phép người dùng nhập vào bao nhiêu số tùy thích. Sau khi nhập xong in ra màn hình các số chẵn trên 1 dòng và số lẻ trên 1 dòng.
                 *
                 * Bài 2: Viết 1 chương trình cho phép người dùng nhập vào 1 dãy điểm. In ra màn hình dãy điểm người vừa nhập và bệnh cạnh mỗi 1 đầu điều thông báo Trượt hoặt đỗ dựa trên điều kiện điểm đỗ >=5 và Trượt <5.
                 *
                 * Bài 3: Viết 1 chương trình nhập nhiều  thông tin của sinh viên POLY. Mỗi sinh viên khi nhập vào cần các thông tin sau: Tên, Năm Sinh, Msv. Sau khi người dùng nhập xong hết thông tin sinh viên cần thêm thì sẽ in tất cả ra màn hình lưu in thêm tuổi của mỗi sinh viên tương ứng.
                 */
        }
    }
}

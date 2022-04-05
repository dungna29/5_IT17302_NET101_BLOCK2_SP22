using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_7_XuLyChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            #region Lý thuyết Xử lý chuỗi
            /*
             * 1. Khai báo chuỗi
             */
            string str, str1, str2; // khai báo danh sách chuỗi
            str = "FPT POLYTECHNIC"; //gán giá trị chuỗi
            str1 = "xử lý chuỗi 1 trong c#";
            str2 = "xử lý chuỗi 2 trong c#";

            /*
             * 2. Lấy chiều dài chuỗi: str.Length: lấy chiều dài chuỗi
             */

            /*
             *3. So sánh 2 chuỗi
             * Cách 1: sử dụng == không phân biệt chữ hoa và thường khi so sánh
             * Cách 2: sử dụng String.Compare (phân biệt hoa thường và không phân biệt hoa thường)
             * String.Compare(str1,str2,true)
             * Đổi thành false là phân biệt chữ hoa chữ thường.
             * Cách 3: sử dụng Equals (có phân biệt chữ hoa và thường khi so sánh)
             *
             *4. Kiểm tra đầu chuỗi và cuối chuỗi có tồn tại chuỗi cần tìm hay không?
             * StartsWith & EndsWith là 2 hàm kiểm tra xem đầu chuỗi hoặc cuối chuỗi có tồn tại ký tự hoặc chuỗi ký tự cần tìm hay không?
             *
             * 5. Kiểm tra sự tồn tại của chuỗi 1 trong chuỗi 2
             * Str1.Contains(Str2) :Kiểm tra trong chuỗi Str1 có chuỗi Str2 hay không?
             *
             * 6. Tìm vị trí hiển thị của chuỗi
             * Str1.IndexOf("chuỗi"): Vị trí xuất hiện đầu tiên của ký tự "chuỗi" trong Str1.
                Trả về -1 nếu trong Str1 không có ký tự "chuỗi".
               7. Tìm vị trí xuất hiện cuối cùng của chuỗi
                Str1.LastIndexOf("chuỗi"): Vị trí xuất hiện cuối cùng của ký tự "chuỗi" trong Str1.
                Trả về -1 nếu trong Str1 không có ký tự "chuỗi".    
                8.Kiểm tra xem chuỗi 1 có bắt bầu bằng ký tự trong chuỗi 2 không.
                Str1.StartsWith(Str2):Kiểm tra xem chuỗi Str1 có bắt đầu bằng chuỗi Str2 không?
                9. Thay thế chuỗi
                Str = Str.Replace(",","."):Thay thế dấu ',' thành dấu '.' trong chuỗi Str.
                Str = Str.Replace("xử lý","hàm chuỗi"):Thay thế chuỗi 'xử lý' thành chuỗi ''hàm chuỗi' trong chuỗi Str
                Thay thế chuỗi đầu tiên được tim thấy và tùy chỉnh số lượng thay thế của chuỗi.
                10. Cắt chuỗi con
                Str1 = Str.SubString(4):Tạo chuỗi con từ chuỗi Str bắt đầu từ vị trí 4 đến hết
                Str1 = Str.Substring(0,8): Cắt chuỗi từ vị trí đầu tiên(vị trí 0) đến vị trí số 8, kết quả là 'hàm xử'
                11. Tách chuỗi .Split (Chuyển từ chuỗi string sang mảng Array)
                string str="các hàm xử lý chuỗi, xử lý chuỗi trong c#";
                string[] arrListStr = str.Split(',');//tách trong chuỗi str trên khi gặp ký tự ','
                kết quả arrListStr[0]='các hàm xử lý chuỗi' và arrListStr[1]='xử lý chuỗi trong c#'
                12. Chuyển từ mảng Array sang chuỗi String với String.Join
                Hàm string.join giúp convert chuyển từ mảng array sang chuỗi.
                string[] Array= new string[] { "xử lý", "chuỗi trong", "c#" };
                string str = string.Join(", ", Array);
            13. Chuyển chữ hoa sang chữ thường và ngược lại
                Str1 = Str.ToLower() :Chuyển chuỗi sang chữ thường
                Str1 = Str.ToUpper() Chuyển chuỗi sang chữ hoa
            14. Cắt hết khoảng trắng ở đầu và cuối.
                Str = Str.Trim() Cắt hết khoảng trắng ở đầu và cuối chuỗi
                Str = Str.TrimLeft() Cắt hết khoảng trắng ở đầu chuỗi
                Str = Str.TrimRight() Cắt hết khoảng trắng ở cuối chuỗi
            15. Xóa chuỗi
                Str1.Remove(2): Xóa chuỗi Str1 từ vị trí 2 đến hết.
                Str.Remove(4,9) : Xóa 1 chuỗi con trong Str1 có chiều dài là 6. Từ vị trí 4 đến vị trí 9
            16. Cắt/Xóa ký tự đặc biệt hay bất kỳ ở đầu và cuối chuỗi.
                Key serch: xóa ký tự cuối cùng hay đầu chuỗi hay bất kỳ trong c#
                Xóa ký tự đặc biệt hay chỉ định bất kỳ ở đầu chuỗi:
            TrimStart(KyTuCanXoa)
            Hàm xóa đầu chuỗi những ký tự hoặc chuỗi ký tự được truyền vào.
            Có thể xóa được cả mảng ký tự cần xóa với
            KyTuCanXoa: là 1 ký tự hoặc 1 mảng ký tự cần xóa
            string MyString = "-Xử lý chuỗi C#";
            string NewString = MyString.TrimStart('-');
            Xóa ký tự đặc biệt hay chỉ định bất kỳ ở cuối chuỗi:
            TrimEnd(KyTuCanXoa)
            Hàm xóa cuối chuỗi những ký tự hoặc chuỗi ký tự được truyền vào.
            Có thể xóa được cả mảng ký tự cần xóa với
            KyTuCanXoa: là 1 ký tự hoặc 1 mảng ký tự cần xóa
             */
            #endregion
        }
    }
}

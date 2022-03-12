using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_6_ToanTuBaNgoi
{
    internal class Program
    {
        /*
    * TOÁN TỬ 3 NGÔI
    * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
        */
        static void Main(string[] args)
        {
            //Hỗ trợ hiển thị tiếng việt
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string temp1 = 9 > 8 ? "Đúng" : "Sai";
            int temp2 = 9 > 8 ? 1 : 0;
            bool temp3 = 9 > 8 ? true : false;
            double temp4 = 9 > 8 ? 1.2 : 3.2;
            Console.WriteLine(temp1);

            /*
            * Bài tập: Viết 1 chương trình khi nhập thông tin 1 người xác định được là ANH, CHỊ, EM, BẠN.
            * Cố định lại Tuổi và Giới Tính của bản thân
            */
            int namSinhBanThan = 2002, gioiTinh = 1;//Cố định 1 = Nam | 0 = Nữ
            //Yêu cầu nhập vào TÊN - NĂM SINH - GIỚI TÍNH có thể xác định được tên gọi như ở trên.
            //+1 điểm vào ASS1 ASS4 cho 4 bạn code nhanh và đúng nhất sử dụng toán tử 3 ngồi.
            string tenBan;
            int nsBan, gtBan;
            while (true)
            {
                Console.Write("Mời bạn nhập tên: ");
                tenBan = Console.ReadLine();
                Console.Write("Mời bạn nhập tuổi: ");
                nsBan = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập giới tính: ");
                gtBan = Convert.ToInt32(Console.ReadLine());
                string temp11 = (nsBan < namSinhBanThan && gtBan == 1) ? "Anh" :
                    (nsBan < namSinhBanThan && gtBan == 0) ? "Chị" :
                    (nsBan > namSinhBanThan && gtBan == 1) ? "Em Trai" :
                    (nsBan > namSinhBanThan && gtBan == 0) ? "Em Gái" : "Bạn";
                Console.WriteLine($"Chào {temp11} {tenBan}");
            }
        }
    }
}

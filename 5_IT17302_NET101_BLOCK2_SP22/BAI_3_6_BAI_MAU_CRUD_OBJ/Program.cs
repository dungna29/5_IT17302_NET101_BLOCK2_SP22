using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_6_BAI_MAU_CRUD_OBJ
{
    internal class Program
    {
        /*
         * 1. Program - Menu
         * 2. Nguoi - Lớp obj
         * 3. NguoiYeuMoi - Obj
         * 4. NguoiYeuMoiService - Nơi code các chức năng
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            NguoiYeuMoiService nym = new NguoiYeuMoiService();
            do
            {
                nym.themNY();
                nym.inDs();
            } while (true);
        }
    }
}

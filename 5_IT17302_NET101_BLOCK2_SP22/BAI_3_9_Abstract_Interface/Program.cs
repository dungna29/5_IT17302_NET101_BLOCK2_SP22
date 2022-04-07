using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_9_Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISinhVienService iSinhVienService = new SinhVienService();
            iSinhVienService.themSinhVien(null);
        }
    }
}

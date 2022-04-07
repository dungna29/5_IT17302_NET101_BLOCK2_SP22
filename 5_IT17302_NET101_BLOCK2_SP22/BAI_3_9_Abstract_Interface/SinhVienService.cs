using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_9_Abstract_Interface
{
    //1 Lớp có thể Implement nhiều Interface
    internal class SinhVienService : ISinhVienService
    {
        public void themSinhVien(SinhVien sv)
        {
            throw new NotImplementedException();
        }

        public void suaSinhVien()
        {
            throw new NotImplementedException();
        } 
        public void xoaSinhVien()
        {
            throw new NotImplementedException();
        }
        public void tkSinhVien()
        {
            throw new NotImplementedException();
        }
    }
}

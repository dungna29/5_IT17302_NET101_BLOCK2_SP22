using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_9_Abstract_Interface
{
    public interface ISinhVienService
    {
        /*
         * - Trong interface không được private
         * - Tên interface luôn đi kèm với tên Service và có chữ I đứng đầu
         * - Các phương thức trong interface luôn là public và là dạng abstract
         */
        void themSinhVien(SinhVien sv);
        void suaSinhVien();
        void xoaSinhVien();
    }
}

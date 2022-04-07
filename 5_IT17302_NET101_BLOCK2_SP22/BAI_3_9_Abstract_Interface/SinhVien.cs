using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_9_Abstract_Interface
{
    /*
     * Khi lớp con kế thừa 1 lớp abstract thì bắt buộc phải ghi đè hết tất cả các phương thức abstract của lớp cha
     */
    public class SinhVien:Nguoi
    {
        private string att4;

        public SinhVien()
        {
            
        }

        public SinhVien(string att1, string att2, string att3, string att4) : base(att1, att2, att3)
        {
            this.att4 = att4;
        }

        public string Att4
        {
            get => att4;
            set => att4 = value;
        }

        public override void method1(int a, string b)
        {
            base.method1(a, b);
        }

       
        /*
         * Bắt buộc ghi đè lại phương thức.
         */
        public override int method3()
        {
            //Triển khai code bên trong hoàn thành bình thường.
            return 1 + 1;
        }

        public override void method4(int a, string b)
        {
            throw new NotImplementedException();
        }
    }
}

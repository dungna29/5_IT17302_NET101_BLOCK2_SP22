using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_9_Abstract_Interface
{
    /*
     * 1. Lớp cha abstract về bản chất vẫn là 1 lớp cha hoàn toàn bình thường như lớp cha đã học.
     * 2. Khi đã gọi là lớp abstract thì phải có phương thức abstract
     */
    abstract class Nguoi
    {
        private string att1;
        private string att2;
        private string att3;

        public Nguoi()
        {
            
        }

        public Nguoi(string att1, string att2, string att3)
        {
            this.att1 = att1;
            this.att2 = att2;
            this.att3 = att3;
        }
        //Các property
        public string Att1
        {
            get => att1;
            set => att1 = value;
        }

        public string Att2
        {
            get => att2;
            set => att2 = value;
        }

        public string Att3
        {
            get => att3;
            set => att3 = value;
        }

        public virtual void method1(int a, string b)
        {

        } 
        public virtual void method2(int a, string b)
        {

        }

        /*
         * Phương thức abstract
         * 1. Phương thức sẽ không có body code
         * 2. Phương thức vẫn tương tự như phương thức đã học nhưng có từ khóa abstract
         */
        public abstract int method3();
        public abstract void method4(int a, string b);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_4_Method
{
    internal class Method_TraVe
    {
        /*
          *  Phương thức trả về là :
          *   Công thức chung:
          *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
          *  {
          *          Body code
          *          return <Kiểu trả về của phương thức>
          *  }
          */
        /*
        * Hướng dẫn sử dụng:
        *      1. Phương thức phải có kiểu trả về là các kiểu dữ liệu...
        *      2. Phải Sử dụng return <giá trị hoặc tập giá trị> đúng với kiểu dữ liệu
        */
        //Ví dụ 1:
        public int tinhTong(int a,int b)
        {
            return a + b;
        }
        //Ví dụ 2: 1 Tập giá trị năm từ 1800 - 2022
        public int[] getYears1800_2022()
        {
            int[] arr = new int[2023 - 1800];
            int temp = 1800;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = temp;
                temp++;
            }

            return arr;
        }
        //Ví dụ 3: 
        public List<string> getLstNames()//Trả ra 1 tập gái trị string có kiểu dữ liệu là List String
        {
            return new List<string> {"DũnG", "Long"};
        }
    }
}

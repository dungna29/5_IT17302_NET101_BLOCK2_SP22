using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_4_Method
{
    internal class Program
    {/*
       *  Bài 2.9 Phương thức - Method
       *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
       *  LỢI ÍCH: - Giúp quản lý code tốt hơn
       *           - Tái sử dụng
       *
       *  Công thức chung:
       *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
       *  {
       *          Body code
       *  }
         *
       * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default, Internal
       *
       * <Kiểu trả về> : có 2 kiểu trả về và không trả về
       *          - Kiểu không trả về: void
       *          - Kiểu trả về: là giá trị đơn(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
       *
       * <Tên phương thức>: Tên động từ viết thường + tên.
       * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số và kiểu dữ liệu.
        
        PHƯƠNG THỨC KHÔNG ĐƯỢC TRÙNG TÊN NHƯNG ĐƯỢC PHÉP TRÙNG TÊN VÀ KHÁC THAM SỐ
       */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            #region 1. Phương thức không trả về
            //Cách gọi phương thức: Cần biết tên phương thức và phương thức đang nằm trong class nào
            MethodVoid mtMethodVoid = new MethodVoid();//Phương thức nằm ở đây
            mtMethodVoid.tinhTong2So();//Gọi đến phương thức cần sử dụng và kết thúc bằng dấu ();

            //Sử dụng phương có tham số cần lưu ý:
            // 1. Truyền  tham số đúng vị trí,
            // 2. Đúng kiểu dữ liệu,
            // 3. Đủ tham số đầu vào không được thiếu

            //mtMethodVoid.tinhTong(1);Truyền thiếu tham số
            mtMethodVoid.tinhTong(1,2);
            mtMethodVoid.tinhTong(1,2,4);

            //Lưu ý: Truyền số lượng tham số sẽ quyết định việc gọi vào phương thức nào trong nạp chồng.
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_6_BAI_MAU_CRUD_OBJ
{
    //Code các chức năng ở đây
    internal class NguoiYeuMoiService_NangCao
    {
        //Triển khai biến toàn cục trên đầu
        private List<NguoiYeuMoi> _lstNYMoi;
        private NguoiYeuMoi _NYMoi;
        private string _input;
        public NguoiYeuMoiService_NangCao()
        {
            _lstNYMoi = new List<NguoiYeuMoi>();
            fake5Data();//Khi khởi tạo lớp Service sẽ có sẵn 5 phần tử bên trong List
        }

        private void fake5Data()
        {
            _lstNYMoi = new List<NguoiYeuMoi>
            {
                new NguoiYeuMoi("A","09876",0,50,"Game"),
                new NguoiYeuMoi("B","09976",0,50,"Xem phim"),
                new NguoiYeuMoi("C","09176",0,60,"Học"),
                new NguoiYeuMoi("D","09276",0,70,"Game LOL"),
                new NguoiYeuMoi("E","09376",0,80,"Nghe nhạc")
            };

        }

        public void themNY()
        {
           
            _input = getInputValue("số lượng");
            for (int i = 0; i < int.Parse(_input); i++)
            {
                _lstNYMoi.Add(new NguoiYeuMoi(getInputValue("tên"), getInputValue("sdt"), Convert.ToInt32(getInputValue("giới tính")), Convert.ToDouble(getInputValue("cân nặng")), getInputValue("sở thích")));
            }
        }

        public void inDs()
        {
            foreach (var x in _lstNYMoi)
            {
                x.inRaManHinh();
            }
        }
        //Đã làm được chức năng tìm kiếm thì chắc chắn làm được xóa và Sửa
        public void timKiem()
        {
            int temp = getIndexBySdt();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            _lstNYMoi[_lstNYMoi.FindIndex(c=>c.Sdt== getInputValue("sdt"))].inRaManHinh();
        }
        public void xoa()
        {
            int temp = getIndexBySdt();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            _lstNYMoi.RemoveAt(temp);
            Console.WriteLine("Xóa thành công");
        }
        public void sua()
        {
            int temp = getIndexBySdt();
            if (temp == -1)
            {
                Console.WriteLine("Không tìm thấy");
                return;
            }
            Console.WriteLine("1. Sửa tên");
            Console.WriteLine("2. Sửa cân nặng");
            Console.Write("Mời bạn chọn: ");
            _input = Console.ReadLine();
            switch (_input)
            {
                case "1":

                    _lstNYMoi[temp].Ten = getInputValue("lại tên");
                    break;
                case "2":
                    //Làm tương tự
                    break;
            }
            Console.WriteLine("Sửa thành công");

        }
        //Sắp xếp đối tượng
        public void sapXepDoiTuong()
        {
            //In đối tượng đã được sắp xếp ra
            foreach (var x in _lstNYMoi.OrderByDescending(c=>c.CanNang))
            {
                x.inRaManHinh();
            }
            //Nếu muốn sắp xêp List gốc
            _lstNYMoi.OrderBy(c => c.CanNang);//Không tác động vào được list gốc.
            //Cần làm như sau
            var temp = _lstNYMoi.OrderBy(c => c.CanNang).ToList();
            _lstNYMoi = new List<NguoiYeuMoi>();
            _lstNYMoi = temp;

            //Sort theo Comparison
            //Khi sử dụng cách này lớp đối tượng phải kế thừa Icomparer<Obj>
            _lstNYMoi.Sort((x,y)=>x.Sdt.CompareTo(y.Sdt));
        }

        //Ứng dụng các phương thức giúp tối ưu code.
        public string getInputValue(string msg)
        {
            Console.Write($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }
        public int getIndexBySdt()
        {
            _input = getInputValue("sdt");
            // for (int i = 0; i < _lstNYMoi.Count; i++)
            // {
            //     if (_lstNYMoi[i].Sdt == _input)
            //     {
            //        return i;//Trả về vị trí đối tượng
            //     }
            // }
            // return -1;
            return _lstNYMoi.FindIndex(c => c.Sdt == _input);
        }
    }
}

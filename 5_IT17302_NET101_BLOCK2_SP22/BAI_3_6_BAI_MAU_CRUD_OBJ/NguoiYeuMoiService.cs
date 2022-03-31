using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3_6_BAI_MAU_CRUD_OBJ
{
    //Code các chức năng ở đây
    internal class NguoiYeuMoiService
    {
        //Triển khai biến toàn cục trên đầu
        private List<NguoiYeuMoi> _lstNYMoi;
        private NguoiYeuMoi _NYMoi;
        private string _input;
        public NguoiYeuMoiService()
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
            Console.Write("Mời nhập số lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < int.Parse(_input); i++)
            {
                _NYMoi = new NguoiYeuMoi();
                Console.Write("Mời bạn nhập tên: ");
                _NYMoi.Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập sdt: ");
                _NYMoi.Sdt = Console.ReadLine();
                Console.Write("Mời bạn nhập giới tính(1 = Nam |  0 = Nữ): ");
                _NYMoi.GioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập cân nặng: ");
                _NYMoi.CanNang = Convert.ToDouble(Console.ReadLine());
                Console.Write("Mời bạn nhập sở thích: ");
                _NYMoi.SoThich = Console.ReadLine();
                _lstNYMoi.Add(_NYMoi);//Sau khi nhập xong 1 đối tượng thì add vào List
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
            Console.Write("Mời bạn nhập sdt: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNYMoi.Count; i++)
            {
                if (_lstNYMoi[i].Sdt == _input)
                {
                    _lstNYMoi[i].inRaManHinh();
                    //break;
                    //Tại sao phải dùng break?
                    //In thêm câu không tìm thấy nếu không search đc.
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }
        public void xoa()
        {
            Console.Write("Mời bạn nhập sdt: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNYMoi.Count; i++)
            {
                if (_lstNYMoi[i].Sdt == _input)
                {
                    _lstNYMoi.RemoveAt(i);//Xóa 
                    Console.WriteLine("Xóa thành công");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }
        public void sua()
        {
            Console.Write("Mời bạn nhập sdt: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNYMoi.Count; i++)
            {
                if (_lstNYMoi[i].Sdt == _input)
                {
                    Console.WriteLine("1. Sửa tên");
                    Console.WriteLine("2. Sửa cân nặng");
                    Console.Write("Mời bạn chọn: ");
                    _input = Console.ReadLine();
                    switch (_input)
                    {
                        case "1":
                            Console.Write("Mời bạn nhập lại tên: ");
                            _lstNYMoi[i].Ten = Console.ReadLine();
                            break; 
                        case "2":
                            //Làm tương tự
                            break;
                    }
                    Console.WriteLine("Sửa thành công");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy");
        }
    }
}

using BasicPractice.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice.Monitor
{
    class MenuMonitor
    {
        private readonly List<MenuItem> menus = new List<MenuItem>();
        public void show()
        {
            var initMenu = initData();
            menus.AddRange(initMenu);

            while(true)
            {
                Console.WriteLine("Menu");

                for(int i = 0; i < menus.Count; i++)
                {
                    var item = menus[i];
                    Console.WriteLine($@"Bấm phím {i+1}: Làm bài {i+1} {item.Title}");
                }

                Console.WriteLine(@"Nhập số để chọn bài tập: ");
                if(int.TryParse(Console.ReadLine(), out int chooseNum) && chooseNum > 0 && chooseNum <= menus.Count)
                {
                    MenuItem selectedItem = menus[chooseNum - 1];
                    if(selectedItem != null)
                    {
                        Console.Clear();
                        Console.WriteLine($"\n--- {selectedItem.Title} ---");
                        Console.WriteLine(selectedItem.Description);
                        Console.WriteLine(@"\n--- Bắt đầu chạy bài tập ---\n");
                        selectedItem.Run();
                        Console.WriteLine(@"\n--- Kết thúc bài tập ---\n");
                        continue;
                    }
                }
                Console.WriteLine(@"Không hợp lệ. Vui lòng thử lại.");
                Console.WriteLine(@"Nhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }

        private List<MenuItem> initData()
        {
            try
            {
                List<MenuItem> _menus = new List<MenuItem>();
                _menus.Add(new MenuItem
                {
                    Title = @"BÀI TẬP 1: Máy tính BMI (Thực hành Cú pháp cơ bản)",
                    Description = @"
                               Mục tiêu: Làm quen với việc khai báo biến, nhận input từ người dùng, thực hiện các phép toán cơ bản và in kết quả ra màn hình.
                               Yêu cầu:
                               Viết một chương trình yêu cầu người dùng nhập vào chiều cao (mét) và cân nặng (kg).
                               Sử dụng kiểu double để lưu trữ chiều cao và cân nặng.
                               Khai báo một hằng số const cho công thức (ví dụ: const string BmiFormula = ""BMI = weight / (height * height)"";). In hằng số này ra màn hình.
                               Tính chỉ số BMI theo công thức: cân nặng / (chiều cao * chiều cao).
                               Sử dụng Console.ReadLine() để nhận input và double.Parse() hoặc Convert.ToDouble() để chuyển chuỗi thành số.
                               In kết quả BMI ra màn hình, định dạng để chỉ hiển thị 2 chữ số sau dấu phẩy.
                               ",
                    Run = new Exercise1().Run
                });
                return _menus;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}

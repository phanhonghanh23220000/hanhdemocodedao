using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace maytinhcoban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int A, B;
            int tong, hieu, tich;
            double thuong;
            string strA, strB;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("L7L7L7L7L7L7L7L7L7L7L7L7L7L77L7L7L77L7L77L7L7L7L77L7LL7L77L7L77L7L7L77L7L");
            Console.WriteLine("L7L7L7L7L77L7L77L7L77L7L7L77L7L77L7L7L77L7L77L7L7L7L7L7L7L77L7L7L77L7L7L");
            Console.WriteLine("l7l7                                                              l7l7l7");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("L7L7      H   H     H     HH   H   H    H                         L7L7L7");
            Console.WriteLine("L7L7      HHHHH    HHH    H  N H   HHHHHH                         L7L7L7");
            Console.WriteLine("L7L7      H   H   H    H  H    N   H    H                         L7L7L7");
            Console.WriteLine("L7L7                                                              L7L7L7");
            Console.WriteLine("L7L7     CHAÒ MỪNG  ĐẾN VỚI SUPPER CASIO BY HẠNH CODE DẠO         L7L7L7");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("L7L7                                                              L7L7L7");
            Console.WriteLine("L7L7      00       00       00         00        00        00     L7L7L7");
            Console.WriteLine("L7L7   0     0   0   0    0    0     0   0     0   0     0   0    L7L7L7");
            Console.WriteLine("L7L7 0         0      0  0      0   0     0   0     0   0     0   L7L7L7");
            Console.WriteLine("L7L7 0         0       0          0         0         0         0 L7L7L7");
            Console.WriteLine(" =======>> MÌNH MỜI BẠN NHẬP SỐ A :");
            strA = Console.ReadLine();
            Console.WriteLine(" =======>.NHẬP THÊM SỐ B VÀO ĐÂY : ");
            strB = Console.ReadLine();
            A = int.Parse(strA);
            B = int.Parse(strB);
            tong = A + B;
            hieu = A - B;
            tich = A * B;
            thuong = (double)A / B;
            Console.WriteLine(" ----------------- >>>tổng :" + tong);
            Console.WriteLine("------------------ >>>hiệu :" + hieu);
            Console.WriteLine(" ------------------>>>tích :" + tich);
            Console.WriteLine("------------------->>>thương :" + thuong);
            Console.WriteLine(" BẠN CÓ MUỐN THỰC HIỆN CHƯƠNG TRÌNH KHÁC ");
            
            
            Console.WriteLine("HẠNH XIN CHÀO BẠN");
            Console.WriteLine(" HẠNH CÓ ĐẸP TRAI KHÔNG/ TRẢ LỜI THẬT LÒNG? chỉ dược nhập CO HOAC KHONG?");
            char i;



            if (char i  == co)
            {
                Console.WriteLine(" ĐÚNG VKL LUÔN BẠN Ạ.CẢM ƠN BẠN ");

            } else if (i ==  'khong')
            {
                Console.WriteLine("ĂN NÓI XÀ LƠ - TÌNH NGHĨA ANH EM CÓ CHẮC BÈN LÂU");
            }
            else
            {
                Console.WriteLine(" BẠN NHẬP SAI RỒI BẠN CHỈ ĐƯỢC NHẠP CO HOẶC KHONG");

            }


            
            Console.ReadKey();
        }
    }
}

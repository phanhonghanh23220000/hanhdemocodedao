using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timhovaten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.OutputEncoding = Encoding.UTF8;
            string[] hotendaydu = { "LÊ THỊ LAN HƯƠNG", "LÊ VŨ TRƯỜNG GIANG RIC KÍT", "TRÀN ĐÌNH TRƯỜNG ĐẸP TRAI KHOAI TO ", "PHAN HỒNG HẠNH", "LÊ THỊ HỒNG NHẬN", "À CHÍNH LÀ HÀ HUY HOÀNG", "ĐÀO SĨ CHUNG HIẾU" };
            Console.WriteLine("NHẬP SỐ THỨ TỰ ĐỂ TÌM RA THÔNG TIN HỌ & TÊN:");
            Console.WriteLine("0.  ---------                HƯƠNG");
            Console.WriteLine("1.  ---------                GIANG");
            Console.WriteLine("2.  ---------                TRƯỜNG");
            Console.WriteLine("3.  ---------                HẠNH");
            Console.WriteLine("4.  ---------                NHẬN");
            Console.WriteLine("5.  ---------                HOÀNG");
            Console.WriteLine("6.  ---------                HIẾU");
            Console.WriteLine(" DESIGN _ BY _ HANH CODE DAO   *-*-*-*-*-8-8-*_");
               

            int i = Convert.ToInt32(Console.ReadLine());


            if (i == 0)
            {
                Console.WriteLine(hotendaydu[0]);
            }
            if (i == 1)
            {
                Console.WriteLine((hotendaydu[1]));
            }
            if (i == 2)
            {
                Console.WriteLine(hotendaydu[2]);
            }
            if (i == 3)
            {
                Console.WriteLine(hotendaydu[3]);
            }
            if (i == 4)
            {
                Console.WriteLine(hotendaydu[4]);
            }
            if (i == 5)
            {
                Console.WriteLine(hotendaydu[5]);
            }
            if (i == 6)
            {
                Console.WriteLine(hotendaydu[6]);
            }
            else if (i > 6)
            {
                Console.WriteLine("CẢNH BÁO !   KHÔNG CÓ SỐ THỨ TỰ NÀY TRONG DANH SÁCH    XXXXXXXX");
Console.WriteLine("MẤT CÔNG NHẬP RỒI THÌ VUI LÒNG NHẬP CHO ĐÚNG   XXXXXXXXXXX  !");
Console.ReadLine();
                
            }
            Console.WriteLine("design _ by _ Hanh Code Dạo .....");
                
    
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtralicgam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("hello !");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("NHẬP VÀO NĂM BẤT KÌ BẠN MUỐN");
            string[] namam1= { "CANH", "TÂN", "NHÂM", "QUÝ", "GIÁP", "ẤT", "ĐINH", "MẬU", "KỊ" };
            string[] namam2 = { "THÂN", "DẬU", "TUẤT", "HỢI", "TÍ", "SỬU", "DẦN", "MẠO", "THÌN", "TỊ,NGỌ'MÙI" };
            Console.WriteLine(" NAMW {0}  CÓ NĂM ÂM LỊCH LÀ: {1} {2]" ,year, namam1[year% 10], namam2[year%12]);

        }
    }
}

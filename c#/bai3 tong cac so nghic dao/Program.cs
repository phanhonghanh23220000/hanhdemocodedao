using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_tong_cac_so_nghic_dao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.OutputEncoding = Encoding.UTF8;//chuyen sang tieng viet
            Console.WriteLine("Nhập số n: ");// lenh nhap vao so n
            int n = Convert.ToInt32(Console.ReadLine());//chuyen doi kieu int32 bit

            double sum = 0;//dung dopble de cho gia tri ket qua chinh xac
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine("Tổng của dãy số nghịch đảo từ 1 đến {0} là: {1}", n, sum);

        }
    }
}

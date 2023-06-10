using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_day_so_tu_1_den_2n_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("NHẬP SỐ N:");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for(int i = 0;i <= n; i++)
            {
                sum = +1.0 / (2 * i + 1);
                
                
            }
               Console.WriteLine("TỔNG DÃY SỐ TỪ 1 ĐÉN 1 /(2n + 1) là :{0}",sum);
             Console.ReadLine();
        }
       
    }
}

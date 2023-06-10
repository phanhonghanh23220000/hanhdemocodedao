using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_thay_dong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1^2+ 2^2 + .... n2
            int n;
            int sum = 0;
            
            Console.WriteLine("Nhap vao gia tri n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i * i;
            }
            Console.WriteLine("sum is :" + sum);
            Console.ReadLine();
        }
    }
}

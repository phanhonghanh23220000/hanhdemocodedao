using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitinhtong1
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị n: ");
            int n = Convert.ToInt32(Console.ReadLine());                                                         

            int sum = n * (n + 1) / 2;

            Console.WriteLine("Tổng S({0}) = {1}", n, sum);
        }
    }
}

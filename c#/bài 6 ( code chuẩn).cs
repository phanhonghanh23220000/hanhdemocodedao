using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i * (i + 1));
            }

            Console.WriteLine("Giá trị của S(n) là: " + sum);
        }
    }
    
}

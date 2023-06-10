using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;// khai báo bien n
            Console.OutputEncoding = Encoding.UTF8;// go dau tieng viet
            Console.Write("Nhập giá trị n: ");
            n =

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i * (i + 1));
            }

            Console.WriteLine("Giá trị của S(n) là: " + sum);
        }

    }

}



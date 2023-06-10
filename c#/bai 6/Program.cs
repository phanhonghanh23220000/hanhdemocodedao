using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_6
{
    internal class Program
    {
        static void Main(string[] args)
            //tinh s(n) = 1/1 x2 + 1/2 x3 + ... + 1/n x ( n+1 )
        {
            int n; // khai nao bien n
            Console.WriteLine(" please any kEY (N) : ?");
            Console.OutputEncoding = Encoding.UTF8;
            n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            for (int i = 0; i <= n; i++)
            {
                sum += 1.0 / (i * (i + 1));
            }
            Console.Write(" Sum is : "  +sum);
        }
    }
}

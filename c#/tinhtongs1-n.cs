using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //S(n) = n(n/2) * ( a + b)

            Console.WriteLine("NHAP SO N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = (n * (n + 1)) / 2;
            Console.WriteLine("TONG DAY SO TU 1 DEN {0} LA :{1}", n, sum);
            Console.ReadKey();
        }
              
    }
}

    
    


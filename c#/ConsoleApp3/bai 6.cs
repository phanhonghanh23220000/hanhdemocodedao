using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            Console.WriteLine("NhAP VAO SO N:");
            n = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            for(int i =1;i<=n; i++)
            {
                s = s + 1.0 / (i * (i + 1));
            }
   
            Console.WriteLine(" tong la " + s);
            
            
          
            Console.ReadLine();

        }
    }
}

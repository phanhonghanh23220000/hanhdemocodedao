using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" NHAP VAO SO A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("NHAP VAO SO B :");
            int b = int.Parse(Console.ReadLine());
            int answer = 1;
            while (b > 0)
            {
                answer *= a;
                b--;

            }
            {
                Console.Write(" ket qua la" + (answer));
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        // ham ko co tham so
        static void func1() 
        {
            Console.WriteLine("Hello");
        }
        //Hàm có jieeur trả về, Không có tham về
        static void func2()
        {
            string str = "Hello";
            return str;
        }
        //Hàm  ko có kiểu trả về, có tham số
        static string func3(int a, int b)
        {
            int s = a + b;
            Console.WriteLine("Tong la" + s);
        }
        static string func4(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // Goi ham
            func1();
            string s = func2();
            func3(4, 5);
            int sum = func4(5, 6);

        }
    }
}

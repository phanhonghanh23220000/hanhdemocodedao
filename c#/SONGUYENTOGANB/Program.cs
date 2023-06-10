using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SONGUYENTOGANB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            do
            {

                Console.WriteLine(" NHAP VAO SO A");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" nhap vao so B");
                b = Convert.ToInt32(Console.ReadLine());
            } while (a >= b);
            int count = 0;
            for(int i = b -1; i >= a; i--)
            {
                if (count == 0)
                {
                    Console.WriteLine(" khong co so nguyen to trong KHOANG A B");

                }
                else
                {
                    Console.WriteLine("So nguyen to gan nhat B nhat la" + count);
                    
                }
            }
        }
    }
}

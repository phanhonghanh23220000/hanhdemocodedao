using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so_nho_nhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao c");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao d");
            int d = int.Parse(Console.ReadLine());
            if (a == b && b == c && c == d)
            {
                Console.WriteLine(" KHONG CO SO NHO NHAT");
            }
            else
            {
                int min = a;
                if( min > b)
                {
                    min = b;
                }
                if (min > c)
                {
                    min = c;
                }
                if(min > d)
                {
                    min = d;
                }
                Console.WriteLine("GIA TRI NHO NHAT TRONG 4 SO: " +min);
            }

            
            
           


        }
    }
}

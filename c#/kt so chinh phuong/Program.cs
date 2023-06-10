using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kt_so_chinh_phuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" NHAP SO NGHUYEN N");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cac so chinh phuong nho hon: " + n);
            
            
            for(int i = 0;i * i < n;i++)
            {
                Console.WriteLine(i * i + " ");
            }

        }
    }
}

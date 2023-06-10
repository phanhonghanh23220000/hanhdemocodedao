using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giatrilonnhatthu2
{
    internal class Program
    {
        static void Main(string[] args)
        {/* // GIA TRI LON NHAT THU 2
            Console.WriteLine("NHAP VAO SO A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NHAP VAO SO B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NHAP VAO SO C");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NHAP VAO SO D");
            int d = Convert.ToInt32(Console.ReadLine());
            if ( a==b && b ==c && c == d)
            {
                Console.WriteLine(" khong co gia tri nao ca");
            }
            else
            {
                int max = a;
                if(max< b)
                {
                    max = b;
                }
                if( max < c)
                {
                    max = c;
                }
                if(max < d)
                {
                    max = d;
                }// tim min
                int min = a;
                if ( min > b)
                {
                    min = b;

                }
                if (min > c)
                {
                    min = c;
                }
                if( min > d)
                {
                    min = d;
                }
                int max2 = min;
                if( max2 < a && a != max)
                {
                    max2 = a;
                }
                if (max2 < b && b != max)
                {
                    max2 = b;
                }
                if (max2 < c && c != max)
                {
                    max2 = c;
                }
                if (max2 < d && d != max)
                {
                    max2 = d;
                }
                Console.WriteLine(" gia tri lon nhat : " + max);
                Console.WriteLine(" gia tri lon thu 2 : " + max2);
                Console.ReadKey();*/
            /* int a, b;
             Console.WriteLine("NHAP CANH A: ");
             a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("nhap canh b");
             b = Convert.ToInt32(Console.ReadLine());
             if (a >= 0 && b >= 0)
             {
                 int chuvi = 2 * (a + b);
                 int dientich = a * b;
                 Console.WriteLine("CHU VI =: " + chuvi);
                 Console.WriteLine("DIEN TICH = " + dientich);

             }
             else
             {
                 Console.WriteLine(" canh hinh chu nhat phai > 0");
                 Console.Read(); */
            /* Console.Write(" HAY NHAP BAN KINH R > 0 : "); //TINH CHU VI DIEN TICH HINH TRON
              float r = Convert.ToSingle(Console.ReadLine());
              if (r > 0)
              {
                  float chuvi = (float)(2 * Math.PI * r);
                  float s = (float)(Math.PI * r * r);
                  Console.WriteLine($"chu vi duong tron ban kinh {r} la {chuvi}");
                  Console.WriteLine($"dien tich duong trong ban kinh {r} la {s}");
                  Console.ReadLine();
              }
              else
              {
                  Console.WriteLine(" BAN KINH DUONG TRON PHAI DUONG");
              }
            */
            int a, b;
            Console.WriteLine(" nhap he so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NHAP HE SO b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if( a == 0 && b == 0)
            {
                Console.WriteLine("PHUONG TRINH VO SO NGHIEM ");
            }else if (a ==0 && b != 0)
            {
                Console.WriteLine("PHUONG TRINH NAY KYHONG CO NGHIEM!");
            }else
            { 
                float x =  -b / a;
                Console.WriteLine("PHUONG TRINH CO NGHIEM LA: " + x);
                Console.ReadLine();
            }


        }

    }
}

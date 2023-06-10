using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2
            Console.OutputEncoding = Encoding.UTF8;//chuyen sang tiebng viet co dau
            Console.WriteLine(" NHậP VÀO GIÁ TRỊ N :");// lenh nhap vao cau lenh nhap gia tri n
            
            int n = int.Parse(Console.ReadLine());// chuyen doi bien n thanh kieu int 32 bit
                
            double sum = 0; //khai baos bien sum theo kieu double so thuc 
            for ( int i = 1; i<= n; i++)// cho 1 vong lap chay tu i den n
            {
                sum += (2 * i + 1) / (2.0 * (i + 1));
                // dieu kien cua sum
            }
            Console.WriteLine(" Giá trị tổng  S(n) : " +sum); //in ra gia tri sum cau lenh in + sum
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //S(n) = ½ + 2/3 + ¾ + …. + n / n + 1
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write(" NHẬP VÀO GIÁ TRỊ N : ");// IN RA CAU LENH NHAP VAO GIA TRI N;
           
           int  n = Convert.ToInt32(Console.ReadLine());//CHUYEN DOI KIEU N
            double sum = 0;
            for ( int i =1; i <= n; i++)//TAO 1 VONG LAP TU I TU 1 DEN N
            {
                sum += (double)i / (i + 1);
            }
            Console.Write(" TONG S(N) = " + sum);
            Console.Read();


        }
    }
}

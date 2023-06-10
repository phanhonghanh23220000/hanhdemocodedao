using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_1phan2den1phan_n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("Nhập số giá trị n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (2 * i);
            }

            Console.WriteLine("Tổng của dãy số " + sum);

            // Dừng chương trình để đọc kết quả trước khi thoát
            Console.ReadLine();
        }
    }
}

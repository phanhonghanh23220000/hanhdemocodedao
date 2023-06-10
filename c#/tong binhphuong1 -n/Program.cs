using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong_binhphuong1__n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tong day so binh phuong tu 1 den n
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }

            Console.WriteLine("Tổng của dãy số bình phương từ 1 đến {0} là: {1}", n, sum);

            // Dừng chương trình để đọc kết quả trước khi thoát
            Console.ReadLine();


        }
    }
}

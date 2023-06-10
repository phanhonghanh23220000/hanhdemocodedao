using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangcuuchuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("BẢNG CỬU CHƯƠNG LẬP TRÌNH C# CỦA HẠNH");
            for (int i=1;i<=9;i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(i * j + " ");
                } Console.WriteLine();
            }
        }
    }
}

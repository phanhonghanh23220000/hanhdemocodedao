using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i =0;i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    // steam
                    Console.Write("       . . . . o o o o o o", Console.ForegroundColor = ConsoleColor.Gray);
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o", Console.ForegroundColor = ConsoleColor.Green);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o", Console.ForegroundColor = ConsoleColor.Gray );
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Console.ForegroundColor =ConsoleColor.Green);
                    Console.WriteLine(margin + "      [________]_|__|________)< ", Console.ForegroundColor = ConsoleColor.Magenta);
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Console.ForegroundColor =ConsoleColor.Cyan);
                    Console.WriteLine("======================================================================= ---=-=--=-=--=-=-=-==-=-=- ", Console.ForegroundColor = ConsoleColor.Red);

                    Thread.Sleep(300);
                }
            }
        }
    }
}

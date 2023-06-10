using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void ColorfulAnimation()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    // steam
                    Console.Write("       . . . . o o o o o o ò ó o ò O", Console.ForegroundColor = ConsoleColor.Gray);
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o", Console.ForegroundColor = ConsoleColor.Green);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine(margin + "      [________]_|__|________)< ", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+----+---+----+--+--+---+", Console.ForegroundColor = ConsoleColor.Red);
                    Console.WriteLine(margin + "        TẠM BIỆT NHÉ   2023 design by hanh" Console.ForegroundColor = ConsoleColor.Magenta); ;
                    Thread.Sleep(200);
                }
            }
        }


    }
}

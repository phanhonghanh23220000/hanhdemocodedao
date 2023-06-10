using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[10, 8];
            bool[,] cons = new bool[5, 5];
            string[,] something = new string[6, 8];
            int row = cons.GetLength (0);
            int col = cons.GetLength(1);
            Console.WriteLine($"HANG {row},cot{col} ");
            







        }
    }
}

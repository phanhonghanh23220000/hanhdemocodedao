using System;
using System.Text;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập một số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Các số nguyên tố nhỏ hơn {0} là:", n);
        for (int i = 2; i < n; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.ReadLine();
    }
}

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
        int n;

        Console.OutputEncoding = Encoding.UTF8;
        {

    } 

        Console.WriteLine("Nhập số nguyên dương n: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Số không hợp lệ! Vui lòng nhập lại: ");
        }

        int count = 0;
        int currentNumber = 2;

        Console.WriteLine($"Các số nguyên tố gần nhất {n}:");
        while (count < n)
        {
            if (IsPrime(currentNumber))
            {
                Console.WriteLine(currentNumber);
                count++;
            }
            currentNumber++;
        }
    }
}
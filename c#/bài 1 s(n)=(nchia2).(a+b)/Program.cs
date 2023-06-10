//S(n) = n(n/2) * ( a + b)
using System;
class tinhtongcacsotu1denN
    static void Main()
{
    Console.WriteLine("NHAP SO N:");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = (n * (n + 1)) / 2;
    Console.WriteLine("TONG DAY SO TU 1 DEN {0} LA :{1}", n, sum);
    Console.ReadLine();
}
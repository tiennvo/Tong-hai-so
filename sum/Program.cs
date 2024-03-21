using System;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong 2 so la: " + (a + b));
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        do
        {
            Console.Write("Nhap so nguyen n (1 <= n <= 9): ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 9)
            {
                Console.WriteLine("Loi! Vui long nhap n trong khoang tu 1 den 9.");
            }

        } while (n < 1 || n > 9);

        Console.WriteLine("\nBang cuu chuong " + n + ":");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}
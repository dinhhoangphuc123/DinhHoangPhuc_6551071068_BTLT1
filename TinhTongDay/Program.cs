using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        Console.Write("Nhap so nguyen duong n: ");
        n = int.Parse(Console.ReadLine());

        long tong = 0;
        long tongChan = 0;
        long tongLe = 0;

        // Tinh tong 1 + 2 + ... + n
        for (int i = 1; i <= n; i++)
        {
            tong += i;

            if (i % 2 == 0)
            {
                tongChan += i;
            }
            else
            {
                tongLe += i;
            }
        }

        // Tinh giai thua n! bang while
        long giaiThua = 1;
        int iWhile = 1;

        while (iWhile <= n)
        {
            giaiThua *= iWhile;
            iWhile++;
        }

        // In ket qua
        Console.WriteLine("\n===== KET QUA =====");
        Console.WriteLine("Tong 1 + 2 + ... + " + n + " = " + tong);
        Console.WriteLine("Tong cac so chan tu 1 den " + n + " = " + tongChan);
        Console.WriteLine("Tong cac so le tu 1 den " + n + " = " + tongLe);
        Console.WriteLine("Giai thua " + n + "! = " + giaiThua);
    }
}
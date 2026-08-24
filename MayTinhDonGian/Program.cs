using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhap hai so thuc
        Console.Write("Nhap so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so b: ");
        double b = double.Parse(Console.ReadLine());

        // Tinh va in ket qua
        Console.WriteLine("\n--- KET QUA ---");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));

        // Kiem tra b khac 0 truoc khi chia
        if (b != 0)
        {
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("(int)a / (int)b = " + ((int)a / (int)b));
            Console.WriteLine("(int)a % (int)b = " + ((int)a % (int)b));
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0");
            Console.WriteLine("Khong the chia lay phan nguyen");
            Console.WriteLine("Khong the chia lay phan du");
        }

        Console.WriteLine("a ^ b = " + Math.Pow(a, b));
    }
}
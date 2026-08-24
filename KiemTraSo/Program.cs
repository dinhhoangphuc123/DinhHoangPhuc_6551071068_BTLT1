using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap mot so nguyen: ");
        int so = int.Parse(Console.ReadLine());

        // Kiem tra so duong, am hay bang 0
        if (so > 0)
        {
            Console.WriteLine("So duong");
        }
        else if (so < 0)
        {
            Console.WriteLine("So am");
        }
        else
        {
            Console.WriteLine("So bang 0");
        }

        // Kiem tra chan hay le
        if (so % 2 == 0)
        {
            Console.WriteLine("So chan");
        }
        else
        {
            Console.WriteLine("So le");
        }

        // Kiem tra chia het cho 3
        if (so % 3 == 0)
        {
            Console.WriteLine("So chia het cho 3");
        }
        else
        {
            Console.WriteLine("So khong chia het cho 3");
        }

        // Kiem tra chia het cho ca 2 va 3
        if (so % 2 == 0 && so % 3 == 0)
        {
            Console.WriteLine("So chia het cho ca 2 va 3");
        }
        else
        {
            Console.WriteLine("So khong chia het cho ca 2 va 3");
        }
    }
}
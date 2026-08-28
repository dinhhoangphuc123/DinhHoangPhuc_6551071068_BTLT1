using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Nhap so nguyen duong n (n <= 1000): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0 || n > 1000)
            {
                Console.WriteLine("Loi! Vui long nhap n trong khoang tu 1 den 1000.");
                return;
            }

            int soLuong = 0;

            Console.WriteLine("\n===== CAC SO NGUYEN TO =====");

            // Duyet cac so tu 2 den n
            for (int i = 2; i <= n; i++)
            {
                bool laSoNguyenTo = true;

                // Kiem tra i co phai so nguyen to khong
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }

                if (laSoNguyenTo)
                {
                    Console.Write(i + " ");
                    soLuong++;
                }
            }

            Console.WriteLine("\n\nTong so luong so nguyen to: " + soLuong);
        }
        catch (FormatException)
        {
            Console.WriteLine("Loi! Du lieu nhap vao phai la so nguyen.");
        }
    }
}
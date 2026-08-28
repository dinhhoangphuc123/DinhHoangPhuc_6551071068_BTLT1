using System;

class Program
{
    static void Main(string[] args)
    {
        int[] mang = new int[10];

        // Nhap mang
        for (int i = 0; i < mang.Length; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        // In toan bo mang bang foreach
        Console.WriteLine("\n===== TOAN BO MANG =====");

        foreach (int x in mang)
        {
            Console.Write(x + " ");
        }

        // Tinh tong, so chan, so le bang foreach
        long tong = 0;
        int soChan = 0;
        int soLe = 0;

        foreach (int x in mang)
        {
            tong += x;

            if (x % 2 == 0)
            {
                soChan++;
            }
            else
            {
                soLe++;
            }
        }

        double trungBinh = (double)tong / mang.Length;

        // Tim gia tri lon nhat va nho nhat
        int lonNhat = mang[0];
        int nhoNhat = mang[0];
        int viTriLonNhat = 0;
        int viTriNhoNhat = 0;

        for (int i = 1; i < mang.Length; i++)
        {
            if (mang[i] > lonNhat)
            {
                lonNhat = mang[i];
                viTriLonNhat = i;
            }

            if (mang[i] < nhoNhat)
            {
                nhoNhat = mang[i];
                viTriNhoNhat = i;
            }
        }

        // In ket qua
        Console.WriteLine("\n\n===== KET QUA =====");
        Console.WriteLine("Tong cac phan tu = " + tong);
        Console.WriteLine("Trung binh = " + trungBinh);
        Console.WriteLine("Gia tri lon nhat = " + lonNhat + " tai vi tri " + viTriLonNhat);
        Console.WriteLine("Gia tri nho nhat = " + nhoNhat + " tai vi tri " + viTriNhoNhat);
        Console.WriteLine("So luong phan tu chan = " + soChan);
        Console.WriteLine("So luong phan tu le = " + soLe);

        // Dao nguoc mang
        Console.WriteLine("\n===== MANG SAU KHI DAO NGUOC =====");

        for (int i = mang.Length - 1; i >= 0; i--)
        {
            Console.Write(mang[i] + " ");
        }

        Console.WriteLine();
    }
}
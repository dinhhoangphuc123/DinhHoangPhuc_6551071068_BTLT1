using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhap ho ten
        Console.Write("Nhap ho ten day du: ");
        string hoTen = Console.ReadLine();

        // Do dai chuoi
        Console.WriteLine("\nDo dai chuoi: " + hoTen.Length);

        // Chuoi chu HOA
        Console.WriteLine("Chuoi chu HOA: " + hoTen.ToUpper());

        // Chuoi chu thuong
        Console.WriteLine("Chuoi chu thuong: " + hoTen.ToLower());

        // Xoa khoang trang hai dau
        string chuoiTrim = hoTen.Trim();
        Console.WriteLine("Chuoi sau khi Trim: " + chuoiTrim);

        // Kiem tra co chua tu "Nguyen" hay khong
        if (chuoiTrim.Contains("Nguyen"))
        {
            Console.WriteLine("Chuoi co chua tu \"Nguyen\"");
        }
        else
        {
            Console.WriteLine("Chuoi khong chua tu \"Nguyen\"");
        }

        // Tach chuoi thanh tung tu
        string[] cacTu = chuoiTrim.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("\n===== CAC TU TRONG HO TEN =====");

        foreach (string tu in cacTu)
        {
            Console.WriteLine(tu);
        }

        // Ghep lai bang dau "-"
        string chuoiGhep = String.Join("-", cacTu);

        Console.WriteLine("\nChuoi sau khi ghep: " + chuoiGhep);
    }
}
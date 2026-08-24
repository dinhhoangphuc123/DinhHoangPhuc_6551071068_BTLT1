using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap nhiet do Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine("Fahrenheit = " + fahrenheit);
        Console.WriteLine("Kelvin = " + kelvin);
    }
}
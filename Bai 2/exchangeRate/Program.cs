using System;
namespace exchangeRate
{
class Program
{
    private static void Main(string[] args)
    {
        float ExchangRate = 23000;
        float VND;
        Console.WriteLine("nhap so tien VND: ");
        VND = float.Parse(Console.ReadLine());
        Console.WriteLine("so tien cua ban la: " + VND*ExchangRate);
    }
}
}
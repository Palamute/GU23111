using System;
namespace UsingOperator
{
class Program
{
    private static void Main(string[] args)
    {
        float width;
        float height;
        Console.WriteLine("nhap gia tri cgo hinh chu nhat");
        Console.WriteLine("nhap chieu rong: ");
        width = float.Parse(Console.ReadLine());
        Console.WriteLine("nhhap chieu cao: ");
        height = float.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh chu nhat la: " + width*height);
        
    }
}
}

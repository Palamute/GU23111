using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("Nhap lua chon:");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine(CelsiusToFahrenheit());
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine(FahrenheitToCelsius());
                    }
                    break;
                case 0:
                    {
                        Environment.Exit(0);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Nhap Lai");
                    }
                    break;
            }
        }
    }
    static double CelsiusToFahrenheit()
    {
        Console.Write("Nhap Do C: ");
        int celsius = int.Parse(Console.ReadLine());
        double fahrenheit = 9 / 5 * celsius + 32;
        return fahrenheit;
    }
    static double FahrenheitToCelsius()
    {
        Console.Write("Nhap do F: ");
        int fahrenheit = int.Parse(Console.ReadLine());
        double celsius = 5/9 * (fahrenheit - 32);
        return celsius;
    }
}
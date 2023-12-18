using System;

namespace ExchangeRate
{
    class Program
    {
        private static void Main(string[] args)
        {
            double ExchangeRate = 23000.0;
            double VND;

            Console.WriteLine("Nhập số tiền VND: ");
            VND = double.Parse(Console.ReadLine());

            double USD = VND / ExchangeRate;

            Console.WriteLine("Số tiền của bạn là: " + USD.ToString("N2") + " USD");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        int count = -1;
        while (count != 0)
        {
            Console.WriteLine("Nhap mot so");
            count = int.Parse(Console.ReadLine());
            switch (count)
            {
                case 1:
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                }
                break;
                case 2:
                {
                    for (int i = 1; i < 6; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                }
                break;
                case 3:
                {
                    for (int i = 0; i < 20; i++)
                      {
                         for (int j = 1; j <= 20 - i; j++)
                         Console.Write(" ");
                         for (int j = 1; j <= 2 * i - 1; j++)
                         Console.Write("*");
                         Console.Write("\n");
                       }
                }
                break;
                case 4:
                {
                    Console.WriteLine("hello");
                }
                break;
                default:
                Console.WriteLine("Nhap lai");
                break;
            }
        }
    }
}
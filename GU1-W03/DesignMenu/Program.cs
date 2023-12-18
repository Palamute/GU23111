internal class Program
{
    private static void Main(string[] args)
    {
        int choise = -1;
        while (choise!=0)
        {
            Console.WriteLine("Nhap mot ki tu tu ban phim");
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("*********");
                    Console.WriteLine("********");
                    Console.WriteLine("*******");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                }
                break;
                case 2:
                {
                Console.WriteLine("**********");
                Console.WriteLine("**********");
                Console.WriteLine("**********");
                Console.WriteLine("**********");
                Console.WriteLine("**********");
                }
                break;
                case 3:
                {
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                    Console.WriteLine("**********");
                }
                break;
                default: Console.WriteLine("Nhap lai");
                break;
            }
        }
    }
}
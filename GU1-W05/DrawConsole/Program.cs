internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;
       while (true)
       {
        keyInfo = Console.ReadKey();
        Console.WriteLine(keyInfo.Key);
        if(keyInfo.Key==ConsoleKey.UpArrow||keyInfo.Key==ConsoleKey.W)
        {
            Console.WriteLine("Di len");
        }
        if(keyInfo.Key==ConsoleKey.RightArrow||keyInfo.Key==ConsoleKey.D)
        {
            Console.WriteLine("Sang Phai");
        }
        if(keyInfo.Key==ConsoleKey.LeftArrow||keyInfo.Key==ConsoleKey.A)
        {
            Console.WriteLine("Sang Trai");
        }
        if(keyInfo.Key==ConsoleKey.DownArrow||keyInfo.Key==ConsoleKey.S)
        {
            Console.WriteLine("Di Xuong");
        }
       }
    }
}

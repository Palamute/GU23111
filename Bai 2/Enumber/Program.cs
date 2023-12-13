enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter,
}

class Program
{
    private static void Main(string[] args)
    {
        Season mySeason = Season.Autumn;
        Console.WriteLine(Season.Spring);
        switch (mySeason)
        {
            case Season.Spring: Console.WriteLine("Day la mua xuan");
            break;
            case Season.Summer: Console.WriteLine("Day la mua ha");
            break;
            case Season.Autumn: Console.WriteLine("Day la mua thu");
            break;
            case Season.Winter: Console.WriteLine("Day la mua dong");
            break;
            default: Console.WriteLine("khong phai mua nao");
            break;
        }
    }
}
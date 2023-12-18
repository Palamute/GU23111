internal class Program
{
    private static void Main(string[] args)
    {
        string[] nameList = {"Nam", "Trung", "Kien", "Binh", "Lam", "Bac"};
        Console.WriteLine("Nhap ten ban: ");
        string name = Console.ReadLine();
        bool istrue = false;
        for (int i = 0; i <= nameList.Length-1; i++)
        {
            if(nameList[i].Equals(name))
            {
                Console.WriteLine($"co ten trong mang va vi tri {i+1}");
                istrue = true;
                break;
            }
        }
        if(!istrue)
        {
            Console.WriteLine("khong co ten");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
       int size = 0;
       do{
        Console.WriteLine("Nhap kich thuoc mang");
        size = int.Parse(Console.ReadLine());
        if(size>20) Console.WriteLine("gia tri nhap qua 20 yeu cau nhap lai");
       }while (size>20);
       int[] array = new int[size];
       Console.WriteLine("nhapp phan tu cua mang: ");
       for (int i = 0; i  <= array.Length-1; i++)
       {
        array[i] = int.Parse(Console.ReadLine());
       }
        Console.WriteLine("gia tri cua cac mang la: ");
        for (int i = 0; i <= array.Length-1; i++)
        {
            Console.WriteLine(array[i]+"\t");
        }
        int max = array[0];
        int indexArrayList = 0;
        for (int i = 0; i <= array.Length-1; i++)
        {
            if(array[i]>max)
            {
                max = array[i];
                indexArrayList = i+1;
            }
        }
        Console.WriteLine("gia tri lon nhat la"+ max + "co vi tri "+ indexArrayList);
       
    }
}
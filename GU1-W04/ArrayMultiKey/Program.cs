using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so ham");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap so cot");
        int column = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap cac phan tu cua mang: ");
        int[,] array = new int [row,column];
        for (int i = 0; i< row; i++)
        {
            for (int j = 0; j <column; j++)
            {
                array[i,j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < row; i++)
        {
            Console.WriteLine("\n");
            for (int j = 0; j < column; j++)
            {
                Console.Write(array[i,j] + "\t");
            }
        }
        //gia tri lon nhat cua mang
        int max = array[0,0];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if(max<array[i,j]);
                {
                max = array[i,j];
                }
            }
        }
        Console.WriteLine("gia tri lon nhat la: ");

        //tinh tong
        int total = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if(i==j){
                    total += array[i,j];
                }
            }
        }
        Console.WriteLine("gia tri tong duong cheo la: " + total);
    }
}
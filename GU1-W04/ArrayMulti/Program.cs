internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = {{1,2,3,4},
                         {1,2,3,4}, 
                         {5,6,7,8}, 
                         {9,10,11,12}};
       int max = array[0,0];
       for(int i = 0; i < array.GetLength(0); i++)
       {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > max)
            {
                max = array[i,j];
            }
        }
       }
       Console.WriteLine("gia tri lon nhat cua mang la" + max);
    }
}
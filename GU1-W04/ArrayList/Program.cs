internal class Program
{
    private static void Main(string[] args)
    {
        int [] myList = new int [10];
        int [] myList2 = [1,2,3,4,5,6,7,8,9,10];
        //truy xuất dữ liệu mảng
        //tên mảng chỉ số mảng
        int a = myList[0]; //lấy ra
        myList[0] = 0;   // đưa vào

        Console.WriteLine(myList2.Length); //độ dài của mảng
        Console.WriteLine(myList2.Length-1); //chỉ số cuối cùng của mảng
    }
}
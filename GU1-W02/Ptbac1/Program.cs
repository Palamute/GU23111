using System;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Nhap so a");
       Double a = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Nhap so b");
       Double b = Convert.ToDouble(Console.ReadLine());

       if (a!=0)
       {
        Console.WriteLine("PT co nghiem" + -b/a);
       }
       else{
        if(b==0) Console.WriteLine("PT vo so nghiem");
        else{
            Console.WriteLine("PT vo nghiem");
        }
       }
    }
}
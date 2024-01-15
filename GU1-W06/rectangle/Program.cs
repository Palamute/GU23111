internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(width,height);
        Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rectangle.Getarea());

    }
}
public class Rectangle
{
    double width, height;
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double Getarea()
    {
        return this.width*this.height;
    }
    public double GetPerimeter()
    {
        return (this.width + this.height)*2;
    }
}

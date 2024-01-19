internal class Program
{
    private static void Main(string[] args)
    {
         Circle myCircle = new Circle(5.0, "Red");
        Console.WriteLine(myCircle.ToString());

        Cylinder myCylinder = new Cylinder(3.0, "Blue", 8.0);
        Console.WriteLine(myCylinder.ToString());
    }
}
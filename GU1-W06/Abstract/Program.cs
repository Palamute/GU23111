internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}
public  abstract class Enemy
{
    public abstract void Attack();
}
public class Dragon : Enemy
{
    public override void Attack()
    {
        Console.WriteLine("Cao can xe");
    }
}
public class Robot:Enemy
{
    public override void Attack()
    {
        Console.WriteLine("Ban sung");
    }
}
public class Man:Enemy
{
   public override void Attack()
    {
        Console.WriteLine("Chem");
    } 
}
public abstract class Vehicle
{
    
}
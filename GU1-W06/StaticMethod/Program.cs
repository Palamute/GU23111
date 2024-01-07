internal class Program
{
    private static void Main(string[] args)
    {
        Student.change();
        Student s1 = new Student(111, "Hoang");
        Student s2 = new Student(222, "Khanh");
        Student s3 = new Student(333, "Nam");
        s1.display();
        s2.display();
        s3.display();
    }
}
public class Student
{
    private int rollno;
    private string name;
    private static string college = "BBDIT";
    public Student(int r, string n)
    {
        name = n;
        rollno = r;
    }
    public static void change()
    {
        college = "CODEGYM";
    }
    public void display()
    {
        Console.WriteLine(rollno + " " + name + " " + college);
    }
}
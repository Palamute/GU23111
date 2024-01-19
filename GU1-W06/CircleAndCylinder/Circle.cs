using System;
class Circle
{
    private double radius;
    private string color;
    public Circle(double radious, string color)
    {
        this.radius = radius;
        this.color = color;
    }
    public double getRadius()
    {
        return radius;
    }
    public void setRadious()
    {
        this.radius = radius;
    }
    public string getColor()
    {
        return color;
    }
    public void setColor()
    {
        this.color = color;
    }
    public double getArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    public override string ToString()
    {
        return $"Circle - Radius: {radius}, Color: {color}, Area: {getArea()}";
    }

}
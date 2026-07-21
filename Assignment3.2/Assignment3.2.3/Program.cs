Circle one = new() { Area = 2 };
Circle two = new Circle { Area = 3 };

Console.WriteLine($"Circle one: radius = {one.Radius:F2} units");
Console.WriteLine($"              area = {one.Area:F2} units");

Console.WriteLine($"Circle two: radius = {two.Radius:F2} units");
Console.WriteLine($"              area = {two.Area:F2} units");

Circle sum = one + two;
Circle diff = two - one;

Console.WriteLine($"Circle sum: radius = {sum.Radius:F2} units");
Console.WriteLine($"              area = {sum.Area:F2} units");

Console.WriteLine($"Circle dif: radius = {diff.Radius:F2} units");
Console.WriteLine($"              area = {diff.Area:F2} units");

public class Circle
{
    public double Radius { get; set; }

    public double Area {
        get
        {
            return Math.PI * Radius * Radius;
        }

        set
        {
            Radius = Math.Sqrt(value / Math.PI);
        }
    }

    public static Circle operator +(Circle c1, Circle c2)
    {
        return new Circle() { Area = c1.Area + c2.Area };
    }

    public static Circle operator -(Circle c1, Circle c2)
    {
        return new Circle() { Area = c1.Area - c2.Area };
    }

}
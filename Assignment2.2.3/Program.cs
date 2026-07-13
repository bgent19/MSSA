// Take the input from user to select circle or square and display the calculated area
Console.Write("Enter the shape (circle/square): ");
string? myShape = Console.ReadLine();

switch (myShape)
{
    case "circle":
        
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new() { name = "circle", radius = radius };
        Console.WriteLine($"The area of the circle is: {circle.Area()}");
        break;
    case "square":

        Console.Write("Enter the side length of the square: ");
        double side = Convert.ToDouble(Console.ReadLine());
        Sqauare square = new() { name = "square", side = side };
        Console.WriteLine($"The area of the square is: {square.Area()}");
        break;
    default:
        Console.WriteLine("Invalid shape selected.");
        break;
}




abstract class Shape
{
    public int id;
    public required string name;
    public string? color;
    public abstract double Area();
}

class Circle : Shape
{
    public double radius;
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}

class Sqauare : Shape
{
    public double side;
    public override double Area()
    {
        return side * side;
    }
}
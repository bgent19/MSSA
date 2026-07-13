Console.Write(" Enter the Point 1 X coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write(" Enter the Point 1 Y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());


// I am doing it this way to suppress: Simplify new expression (IDE0090) 
Point p1 = new() { XCoord = x, YCoord = y};

Console.Write(" Enter the Point 2 X coordinate: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write(" Enter the Point 2 Y coordinate: ");
y = Convert.ToInt32(Console.ReadLine());

Point p2 = new() { XCoord = x, YCoord = y };


string position = RightOf(p1, p2) ? "right of" : "not right of";

Console.WriteLine($"Point 1 is {position} Point 2.");



static bool RightOf(Point p1, Point p2)
{
    return p1.XCoord > p2.XCoord;
}

class Point
{
    public int XCoord { get; set; }
    public int YCoord { get; set; }
}
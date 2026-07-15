//Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

//Test Data :

//Input the value for X coordinate :7

//Input the value for Y coordinate :9

//Expected Output :

//The coordinate point(7, 9) lies in the First quadrant.

Console.Write("Input the value for the X coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the value for the Y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

string location = (x, y) switch
{
    (> 0, > 0) => "First quadrant",
    (< 0, > 0) => "Second quadrant",
    (< 0, < 0) => "Third quadrant",
    (> 0, < 0) => "Fourth quadrant",
    (0, not 0) => "Y-axis",
    (not 0, 0) => "X-axis",
    (0, 0) => "origin"
};

Console.WriteLine($"The coordinate point({x}, {y}) lies in the {location}.");
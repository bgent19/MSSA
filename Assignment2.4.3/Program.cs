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

//string location = (x, y) switch
//{
//    (> 0, > 0) => "First quadrant",
//    (< 0, > 0) => "Second quadrant",
//    (< 0, < 0) => "Third quadrant",
//    (> 0, < 0) => "Fourth quadrant",
//    (0, not 0) => "Y-axis",
//    (not 0, 0) => "X-axis",
//    (0, 0) => "origin"
//};

if (x != 0 && y != 0)
{
    // Convert (-PI to PI) into (0 to 2PI) range
    double angle = (Math.Atan2(y, x) + 2 * Math.PI) % (2 * Math.PI);

    // Divide by PI/2 (90 degrees) and round down to get 0, 1, 2, or 3, then add 1
    int location = Convert.ToInt32(Math.Floor(angle / (Math.PI / 2)) + 1);

    Console.WriteLine($"The coordinate point({x}, {y}) lies in Quadrant {location}.");
}
else
{
    Console.WriteLine("The coordinate point lies on an axis or at the origin.");    
}


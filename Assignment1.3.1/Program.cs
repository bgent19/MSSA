
//Write a program in C# to calculate area of triangle, square and rectangle.
//Write 3 different functions for each shape to take dimensions of figure and
//display the area. You may create menus.

using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Welcome to Trig!");

while (true)
{
    switch(DisplayMenuAndChoose())
    {
        case 'T':
            TriangleArea();
            break;
        case 'S':
            SquareArea();
            break;
        case 'R':
            RectangleArea();
            break;
        case 'E':
            return;
        default:
            Console.WriteLine("I didn't understand that input, let's try again.");
            break;

    }
}


char DisplayMenuAndChoose()
{
    Console.WriteLine("What Shape would you like to know the area of?");
    Console.WriteLine("\t(T)riangle");
    Console.WriteLine("\t(S)quare");
    Console.WriteLine("\t(R)ectangle");
    Console.WriteLine("\t(E)xit");
    Console.Write("\nChoice: ");

    return Convert.ToChar(Console.ReadLine());
}

double TriangleArea()
{
    Console.Write("Enter the base length of the Triangle (x): ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the height of the Triangle (y):\t");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"The area of Triangle is (x * y) / 2 so {x} * {y} / 2 = {(x*y)/2.0}");
    Console.WriteLine();

    return (x * y) / 2.0;
}


double SquareArea()
{
    Console.Write("Enter the length of the Square (x):\t");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"The area of Square is (x * x) so {x} * {x} = {(x * x)}");
    Console.WriteLine();

    return x * x;
}

double RectangleArea()
{
    Console.Write("Enter the base length of the Rectangle (x):\t");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the height of the Rectangle (y):\t");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"The area of Rectangle is (x * y) so {x} * {y} = {(x * y)}");
    Console.WriteLine();

    return (x + y);
}
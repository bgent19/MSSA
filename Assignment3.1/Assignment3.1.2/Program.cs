Console.Write("Enter a year: "); ;
int y = Convert.ToInt32(Console.ReadLine());

string yesNo = IsLeapYear(y) ? "is" : "is not";

Console.WriteLine($"{y} {yesNo} a leap year");

static bool IsLeapYear(int y)
{
    return y % 4 == 0 && (y % 100 != 0 || y % 400 == 0);
}

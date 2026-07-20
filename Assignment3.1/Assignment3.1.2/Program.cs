Console.Write("Enter a year: "); ;
int y = Convert.ToInt32(Console.ReadLine());

string yesNo = IsLeapYear(y) ? "is" : "is not";

Console.WriteLine($"{y} {yesNo} a leap year");

static bool IsLeapYear(int year)
{
    if((year%4 == 0) && (year % 400 == 0))
    {
        return true;
    }
    if((year % 4 == 0) && (year % 100 == 0))
    {
        return false;
    }
    if ((year % 4 == 0))
    {
        return true;
    }

    return false;
}

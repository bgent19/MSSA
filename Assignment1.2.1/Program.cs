Console.Write("Input 1st number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input 2nd number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

// This will add 'not ' if the numbers are not equal
string ans = "";
if(!equality(num1, num2))
    ans = "not ";

Console.WriteLine($"{num1} and {num2} are {ans}equal");


bool equality(double num1, double num2)
{
    return num1 == num2;
}
Console.WriteLine("Wanna see a magic trick! C and C++ can't do this!");
Console.Write("Give me a number (it can have a decimal) ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Give me another number (it can have a decimal, too) ");
double num2 = Convert.ToDouble(Console.ReadLine());
double quotient = num1 / num2;
double remainder = num1 % num2;

Console.WriteLine("Ta da! " + num1 + " divided by " + num2 + " is " + quotient + " with a remainder of " + remainder);

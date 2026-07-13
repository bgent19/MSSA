using System.Diagnostics.CodeAnalysis;

Console.WriteLine("I like numbers, how about you?");
Console.Write("Which is your favorite? ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("And your alternative favorite? ");
double num2 = Convert.ToDouble(Console.ReadLine());
double sum = num1 + num2;
Console.WriteLine("Great! Together " + num1 + " and " + num2 + " make " + sum + "! How neat!");

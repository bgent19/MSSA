/**
Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
Temp 0< 10 then Freezing weather
Temp 11-20 then Very Cold weather
Temp 21-35 then Cold weather
Temp 36-50 then Normal in Weather
Temp 51-65 then Its Hot
Temp 66-80 then Its Very Hot
Test Data :
67
Expected Output :
Its very hot.
 **/

Console.Write("Enter a whole number temperature in Fahrenheit: ");
int temperature = Convert.ToInt32(Console.ReadLine());

switch (temperature)
{
    case int n when (n < 10):
        Console.WriteLine("Freezing weather");
        break;
    case int n when (n >= 11 && n <= 20):
        Console.WriteLine("Very Cold weather");
        break;
    case int n when (n >= 21 && n <= 35):
        Console.WriteLine("Cold weather");
        break;
    case int n when (n >= 36 && n <= 50):
        Console.WriteLine("Normal in Weather");
        break;
    case int n when (n >= 51 && n <= 65):
        Console.WriteLine("Its Hot");
        break;
    case int n when (n >= 66 && n <= 80):
        Console.WriteLine("Its Very Hot");
        break;
    default:
        Console.WriteLine("Temperature out of range");
        break;
}

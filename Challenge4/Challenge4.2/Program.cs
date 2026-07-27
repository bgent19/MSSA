Random rand = new();

for(int i = 0; i < 10; i++)
{
    int num1 = rand.Next(100);
    int num2 = rand.Next(100);

    //int num1 = 98;
    //int num2 = 67;

    bool num1Divisible = (num1 % 2 == 0) || (num1 % 3 == 0);
    bool num2Divisible = (num2 % 2 == 0) || (num2 % 3 == 0);

    Console.WriteLine($"{num1} is divisible by 2 or 3? {num1Divisible}");
    Console.WriteLine($"{num2} is divisible by 2 or 3? {num2Divisible}");

    if(num1Divisible && num2Divisible)
    {
        Console.WriteLine($"Product of {num1}*{num2} = {num1 * num2}");
        Console.WriteLine($"Prod23Sum({num1},{num2}) = {Prod23Sum(num1,num2)}");
    }
    else
    {
        Console.WriteLine($"Sum of {num1}+{num2} = {num1 + num2}");
        Console.WriteLine($"Prod23Sum({num1},{num2}) = {Prod23Sum(num1, num2)}");
    }
}



int Prod23Sum(int x, int y)
{
    if( ((x % 2) == 0 || (x % 3) == 0) && ((y % 2) == 0 || (y % 3) == 0) )
    {
        return x * y;
    }
    else
    {
        return x + y;
    }
}
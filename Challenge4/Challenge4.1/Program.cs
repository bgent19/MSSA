Random rand = new();

for(int i = 0; i < 10; i++)
{
    int num = rand.Next();
    Console.WriteLine($"Does {num} contain 3? {ContainsThree(num)}");
}



bool ContainsThree(int n)
{

    while(n > 0)
    {
        if ((n % 10) == 3)
        {
            return true;
        }

        n /= 10;
    }

    return false;
}
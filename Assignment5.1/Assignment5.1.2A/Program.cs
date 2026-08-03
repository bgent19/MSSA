Console.Write("How much of the Fibonacci sequence do you want to see? ");
int n = Convert.ToInt32(Console.ReadLine());

FibIt(n);

FibRec(n);

FibSlow(n);


static void FibIt(int n)
{
    Console.Write($"The first {n} Fibonacci numbers are:");

    if(n == 1)
    {
        Console.WriteLine("[0]");
    }
    else if(n == 2)
    {
        Console.WriteLine("[0,1]");
    }
    else
    {
        int num1 = 0, num2 = 1;
        int cur = num1 + num2; // cur = 1, n = 3
        Console.Write("[0,1,1");
        for(int i = 3; i < n; i++)
        {
            (cur, num2, num1) = (cur + num2, cur, num2);
            Console.Write($",{cur}");
        }
        Console.WriteLine("]");
    }

}

static void FibRec(int n)
{
    Console.Write($"The first {n} Fibonacci numbers are:");

    int[] results = FibRecHelper(n);

    Console.WriteLine($"[{string.Join(',',results)}]");
}

static int[] FibRecHelper(int n)
{
    // base cases
    if(n == 1)
    {
        return [0];
    }

    if(n == 2)
    {
        return[0, 1];
    }

    int[] reclist = FibRecHelper(n - 1);

    return [.. reclist, reclist[^1] + reclist[^2]];
}

static void FibSlow(int n)
{
    Console.Write($"The first {n} Fibonacci numbers are:");

    for (int i = 0; i < n; i++)
    {
        Console.Write(Fibonacci(i) + " ");
    }
}
static int Fibonacci(int n)
{
    if (n <= 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.Write("How many numbers to print: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbersDesc(n);

static void PrintNumbersDesc(int n)
{
    // base case
    if (n == 1)
    {
        Console.Write(n + " ");
        return;
    }

    // recursive case
    Console.Write(n + " ");
    PrintNumbersDesc(n - 1);

}
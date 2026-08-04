Console.Write("How many numbers to print: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbersAsc(n);

static void PrintNumbersAsc(int n)
{
    // base case
    if(n == 1)
    {
        Console.Write(n + " ");
        return;
    }

    // recursive case
    PrintNumbersAsc(n - 1);
    Console.Write(n + " ");
}
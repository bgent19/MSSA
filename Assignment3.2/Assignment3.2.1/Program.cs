
Console.Write("What dimension (n): ");


int n = Convert.ToInt32(Console.ReadLine());


int l = 1;

int[,] matrix = new int[n,n];

for(int i = 0; i < n*n; ++i)
{
    Console.Write($"Enter number {i}: ");
    string num = Console.ReadLine();
    int numL = num.Length;

    if(numL > l)
    {
        l = numL;
    }
    matrix[i / n, i % n] = Convert.ToInt32(num);
}
Console.WriteLine();

for (int i = 0; i < n; ++i)
{
    for (int j = 0; j < n; ++j)
    {
        Console.Write("\t|\t" + string.Format("{0," + l + "}", matrix[i, j]));
    }
    Console.WriteLine("\t|");
    Console.WriteLine();
}



Console.Write("How many natural numbers would you like? ");
int x = Convert.ToInt32(Console.ReadLine());

int[] naturalNums = FirstXNaturalNums(x);

Console.WriteLine($"The first {x} natural numbers are :");
PrintIntArray(naturalNums);
Console.WriteLine($"The Sum is : {SumIntArray(naturalNums)}");

// I will assume x is > 0
int[] FirstXNaturalNums(int x)
{
    int [] naturalArray = new int[x];
    naturalArray[0] = 1;
    for(int i = 1; i < naturalArray.Length; i++ )
        naturalArray[i] = i+1;
    return naturalArray;
}

void PrintIntArray(int[] nums)
{
    foreach (int num in nums)
        Console.Write($"{num} ");
    Console.WriteLine();
}

int SumIntArray(int[] nums)
{
    int sum = 0;
    foreach (int num in nums)
        sum += num;
    return sum;
}


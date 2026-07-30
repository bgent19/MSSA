//Write a program in C# Sharp to count the frequency of each element of an array.
//Test Data :
//Input the number of elements to be stored in the array :3
//Input 3 elements in the array :
//element - 0 : 25
//element - 1 : 12
//element - 2 : 43

Console.Write("Input the number of elements to be stored in the array: ");
int n = Convert.ToInt32(Console.ReadLine());

Dictionary<int, int> counts = [];

Console.WriteLine($"Input {n} elements in the array: ");

for (int i = 0; i < n; i++)
{
    Console.Write($"element - {i}: ");
    int element = Convert.ToInt32(Console.ReadLine());

    if (counts.ContainsKey(element))
    {
        counts[element]++;
    }
    else
    {
        counts[element] = 1;
    }
}

Console.WriteLine("The unique elements found in the array are:");

foreach ((int key, int value) in counts)
{
    if(value == 1)
    {
        Console.WriteLine(key);
    }
}
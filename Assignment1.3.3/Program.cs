Console.Write("Input the number of elements to store in the array : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input {n} number of elements in the array :");

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"element - {i} : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The values store into the array are:");
PrintArray(array);

Console.WriteLine("The values store into the array in reverse are :");

// This works because arrays are passed by reference.
ReverseArray(array);
PrintArray(array);


void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

// wanted to solve this using a while loop instead of a for loop, so I did it this way.
void ReverseArray(int[] arr)
{
    int start = 0;
    int end = arr.Length - 1;
    while (end > start)
    {
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
}

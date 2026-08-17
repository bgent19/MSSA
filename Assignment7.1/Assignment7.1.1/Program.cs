// Selection Sort Implementation

int[] numbers = Enumerable.Range(0, 10)
                          .Select(_ => Random.Shared.Next(1, 101))
                          .ToArray();

Console.WriteLine(string.Join(' ', numbers));
SelectionSort(numbers);
Console.WriteLine(string.Join(' ', numbers));

static void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        int swap = i;

        for(int j = i; j < arr.Length; j++)
        {
            if(arr[j] < arr[swap])
            {
                swap = j;
            }
        }

        (arr[swap], arr[i]) = (arr[i], arr[swap]);
    }
}
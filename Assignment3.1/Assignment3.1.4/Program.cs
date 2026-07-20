Random rand = new();

int[] arr = new int[50];

for(int i = 0; i < arr.Length; ++i)
{
    arr[i] = rand.Next(5);
}

Console.WriteLine(string.Join(" ", arr));
TransformTwoOnesOnce(arr);
Console.WriteLine(string.Join(" ", arr));

static void TransformTwoOnesOnce(int[] a)
{
    for(int cur = 1; cur < a.Length; ++cur)
    {
        int prev = cur - 1;

        if(a[cur] == a[prev] && a[prev] == 1)
        {
            a[prev] = 0;
            a[cur] = 0;
            break;
        }
    }
}



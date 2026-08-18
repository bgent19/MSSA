Console.Write("How many elements in the array: ");

int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];


for(int  i = 0; i < len; i++)
{
    Console.Write($"Element {i+1}: ");

    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"{String.Join(' ', array)}");
array = MergeSort(array);
Console.WriteLine($"{String.Join(' ', array)}");

static int[] MergeSort(int[] arr)
{
    // base case
    if(arr.Length == 1)
    {
        return arr;
    }

    // recursive case
    int[] a = MergeSort(arr[0..(arr.Length / 2)]); // left half
    int[] b = MergeSort(arr[(arr.Length / 2)..]); // right half

    return _Merge(a,b);
}

static int[] _Merge(int[] a, int[] b)
{

    int[] result = new int[a.Length + b.Length];

    int itrA = 0, itrB = 0, itrR = 0;

    // merge
    while(itrA < a.Length && itrB < b.Length)
    {
        if (a[itrA] < b[itrB])
        {
            result[itrR++] = a[itrA++];
        }
        else
        {
            result[itrR++] = b[itrB++];
        }
    }

    // append a
    // a[itrA..].CopyTo(result, itrR);

    while (itrA < a.Length)
    {
        result[itrR++] = a[itrA++];
    }

    // append b
    // b[itrB..].CopyTo(result, itrR);

    while (itrB < b.Length)
    {
        result[itrR++] = b[itrB++];
    }

    return result;
}
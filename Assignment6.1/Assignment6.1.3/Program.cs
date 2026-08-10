int[] a = [0, 1, 0, 3, 12];
Console.WriteLine(ArrayToString(a));
MoveZeroes(a);
Console.WriteLine(ArrayToString(a));

int[] b = [0];
Console.WriteLine(ArrayToString(b));
MoveZeroes(b);
Console.WriteLine(ArrayToString(b));


void MoveZeroes(int[] arr)
{
    int zeroPointer = 0;

    for(int i = 1; i < arr.Length; i++)
    {
        if (arr[i] != 0 && i > zeroPointer)
        { 
            (arr[i], arr[zeroPointer]) = (arr[zeroPointer], arr[i]);
            while (arr[++zeroPointer] != 0) ; 
        }
    }
}

string ArrayToString(int[] arr)
{
    return $"[{string.Join(',', arr)}]";
}
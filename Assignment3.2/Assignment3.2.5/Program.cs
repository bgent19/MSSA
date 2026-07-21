Console.Write("Search([1, 5, 3], 5) ➞ ");
Console.WriteLine(Search([1, 5, 3], 5));

Console.Write("Search([9, 8, 3], 3) ➞ ");
Console.WriteLine(Search([9, 8, 3], 3));

Console.Write("Search([1, 2, 3], 4) ➞ ");
Console.WriteLine(Search([1, 2, 3], 4));


static int Search(int[] array, int target)
{
    int result = -1;

    foreach(var (index, item) in array.Index())
    {
        if(item == target)
        {
            result = index;
            break;
        }
    }

    return result;
}
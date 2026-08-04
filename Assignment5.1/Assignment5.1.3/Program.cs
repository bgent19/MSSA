Console.WriteLine(ContainsDuplicate([1, 2, 3, 1])); // true
Console.WriteLine(ContainsDuplicate([1, 2, 3, 4])); // false
Console.WriteLine(ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2])); // true

static bool ContainsDuplicate(int[] nums)
{
    HashSet<int> seen = [];

    foreach(int n in nums)
    {
        if(!seen.Add(n)) // evaulates to true if seen already has n
        {
            return true;
        }
    }

    return false;
}
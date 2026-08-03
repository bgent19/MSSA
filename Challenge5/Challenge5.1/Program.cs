Console.WriteLine(SingleNumber([2, 2, 1])); // 1
Console.WriteLine(SingleNumber([4, 1, 2, 1, 2])); // 4
Console.WriteLine(SingleNumber([1])); // 1


static int SingleNumber(int[] nums)
{
    HashSet<int> seen = [];

    foreach(int n in nums)
    {
        if(!seen.Remove(n))
        {
            seen.Add(n);
        }
    }

    return seen.First();
}
Console.WriteLine(MissingNumber([3, 0, 1])); // 2
Console.WriteLine(MissingNumber([0, 1])); // 2
Console.WriteLine(MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1])); // 8


static int MissingNumber(int[] nums)
{
    int len = nums.Length;

    int sumTotal = len, sumFound = 0;

    for(int i = 0; i < len; i++)
    {
        sumTotal += i;
        sumFound += nums[i];
    }

    return sumTotal - sumFound;
}
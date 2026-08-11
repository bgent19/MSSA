Console.WriteLine($"[{string.Join(',',ProductExceptSelf([1, 2, 3, 4]))}]");
Console.WriteLine($"[{string.Join(',', ProductExceptSelf([-1, 1, 0, -3, 3]))}]");

static int[] ProductExceptSelf(int[] nums)
{
    int[] result = new int[nums.Length];

    int product = 1;
    result[0] = product;

    // prefix O(n)
    for(int i = 1; i < nums.Length; i++)
    {
        product *= nums[i - 1];
        result[i] = product;
    }


    // suffix O(n)
    product = 1;
    for (int i = nums.Length - 2; i >= 0; i--)
    {
        product *= nums[i + 1];
        result[i] *= product;
    }

    return result;

    // Overall:
    // time: O(n)
    // Extra space: O(1)
}
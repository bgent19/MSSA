Console.WriteLine(ClimbStairs(2)); // 2
Console.WriteLine(ClimbStairs(3)); // 3


static int ClimbStairs(int n)
{
    if (n == 1)
    {
        return 1;
    }

    int cur = 2, prev = 1;

    for (int i = 2; i < n; i++)
    {
        (cur, prev) = (cur + prev, cur);
    }

    return cur;
}
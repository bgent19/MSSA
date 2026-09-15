Console.WriteLine(MaxProfit([7, 1, 5, 3, 6, 4])); // Expect: 5
Console.WriteLine(MaxProfit([7, 6, 4, 3, 1])); // Expect: 0


int MaxProfit(int[] prices)
{

    int minI = 0;
    int maxI = 0;
    int curMax = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < prices[minI])
        {
            curMax = Math.Max(curMax, prices[maxI] - prices[minI]);
            minI = maxI = i;
        }
        else if (prices[i] > prices[maxI])
        {
            maxI = i;
        }
    }

    return Math.Max(curMax, prices[maxI] - prices[minI]);
}
int[] nums = new int[4];

Console.Write("Enter the First number: ");
nums[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Second number: ");
nums[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Third number: ");
nums[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Fourth number: ");
nums[3] = Convert.ToInt32(Console.ReadLine());

int sum;
double avg;

SumAndAvg(nums, out sum, out avg);

Console.WriteLine($"The average of {string.Join(", ", nums)} is: {avg}");
Console.WriteLine($"The total is {sum}");


static void SumAndAvg(int[] n, out int s, out double a)
{
    s = 0;
    foreach(int i in n)
    {
        s += i;
    }

    a = (double)s / n.Length;
}
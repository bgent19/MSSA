Console.Write("Input any number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The digits in the number {num} are {string.Join(' ', Digitize(num))}");

static List<int> Digitize(int n)
{
    // base case
    if(n == 0)
    {
        return [];
    }

    // recursive case
    List<int> result = Digitize(n / 10);
    result.Add(n % 10);
    return result;
}
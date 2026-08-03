Console.WriteLine(AddDigits(1234)); // 10



static int AddDigits(int n)
{
    int result = 0;

    while (n > 0)
    {
        result += n % 10;

        n /= 10;
    }


    return result;
}
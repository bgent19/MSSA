Console.Write("Type to your heart's content and press ENTER when you are finished: ");
string? text = Console.ReadLine();

Console.WriteLine($"Your text contained {NumSpaces(text)} spaces!");

static int NumSpaces(string? s)
{
    int count = 0;

    if (s is null)
        return count;

    foreach (char c in s)
    {
        if(c == ' ')
        {
            count++;
        }
    }

    return count;
}
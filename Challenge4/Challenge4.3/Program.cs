
char[] s1 = ['h', 'e', 'l', 'l', 'o'];
char[] s2 = ['H', 'a', 'n', 'n', 'a', 'h'];

Console.Write("Input: ");
PrintCharArray(s1);
Console.Write("Output: ");
ReverseString(s1);
PrintCharArray(s1);

Console.WriteLine();

Console.Write("Input: ");
PrintCharArray(s2);
Console.Write("Output: ");
ReverseString(s2);
PrintCharArray(s2);

static void ReverseString(char[] s)
{

    int l = s.Length;
    for (int i = 0; i < l / 2; i++)
    {
        char temp = s[i];
        s[i] = s[l - i - 1];
        s[l - i - 1] = temp;

    }
}

static void PrintCharArray(char[] s)
{
    int l = s.Length;

    Console.Write("[");

    for(int i = 0; i < l; i++)
    {
        Console.Write($"\"{s[i]}\"");

        if(i + 1 < l)
        {
            Console.Write(",");
        }
    }

    Console.WriteLine("]");
}
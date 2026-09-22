Console.WriteLine(RemoveDuplicates("abbaca")); // "ca"
Console.WriteLine(RemoveDuplicates("azxxzy")); // "ay"

static string RemoveDuplicates(string s)
{

    Stack<char> letters = new();

    foreach (char c in s)
    {
        if (letters.TryPeek(out char top))
        {
            if (top == c)
            {
                letters.Pop();
                continue;
            }
        }

        letters.Push(c);
    }

    return new string(letters.Reverse().ToArray());
}
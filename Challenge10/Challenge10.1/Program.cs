Console.WriteLine(FindTheDifference("abcd", "abcde")); // output: e
Console.WriteLine(FindTheDifference("", "y")); // output: y

char FindTheDifference(string s, string t)
{
    Dictionary<char, int> letters = [];

    foreach (char c in s)
    {
        letters[c] = letters.GetValueOrDefault(c, 0) + 1;
    }

    foreach (char c in t)
    {
        int val;
        bool found = letters.TryGetValue(c, out val);

        if(!found || val == 0)
        {
            return c;
        }
        else
        {
            letters[c]--;
        }
    }

    return t[0];
}
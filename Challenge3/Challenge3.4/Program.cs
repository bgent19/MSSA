string s1 = "ABFCACDB";

Console.WriteLine($"Smallest after removal from {s1} is: {RemoveABCD(s1)}");
Console.WriteLine($"Without cheating: {RemoveABCDNoCheat(s1)}");
Console.WriteLine($"With a stack: {RemoveABCDStack(s1)}");

string s2 = "ACBBD";

Console.WriteLine($"Smallest after removal from {s2} is: {RemoveABCD(s2)}");
Console.WriteLine($"Without cheating: {RemoveABCDNoCheat(s2)}");
Console.WriteLine($"With a stack: {RemoveABCDStack(s2)}");

/*************************************************************************************************/

int RemoveABCD(string s)
{
    int stringLen;

    do
    {
        stringLen = s.Length;

        // remove AB
        s = s.Replace("AB", "");
        // remove CD
        s = s.Replace("CD", "");


        // if neither removed anything then s.Length won't change
    }
    while (stringLen != s.Length);
    

    return s.Length;
}

/*************************************************************************************************/

int RemoveABCDNoCheat(string s)
{
    bool[] removed = new bool[s.Length];

    for (int i = 0; i < s.Length - 1; i++)
    {
        if (removed[i]) continue;

        if (s[i] == 'A' && FindAndMarkMatch(s, removed, i, 'B'))
            BacktrackToUnmarked(removed, ref i);
        else if (s[i] == 'C' && FindAndMarkMatch(s, removed, i, 'D'))
            BacktrackToUnmarked(removed, ref i);
    }

    return removed.Count(c => !c);
}

bool FindAndMarkMatch(string s, bool[] removed, int start, char target)
{
    for (int j = start + 1; j < s.Length; j++)
    {
        if (removed[j]) continue;
        if (s[j] == target)
        {
            removed[start] = removed[j] = true;
            return true;
        }
        return false; // Stop at first non-removed character
    }
    return false;
}

void BacktrackToUnmarked(bool[] removed, ref int i)
{
    while (i > 0 && removed[i - 1])
        i--;
    i--;
}

/*************************************************************************************************/

int RemoveABCDStack(string s)
{
    Stack<char> letters = new();

    foreach(char c in s)
    {
        if(letters.Count > 0 &&
            ((letters.Peek() == 'A' && c == 'B')
            ||
             (letters.Peek() == 'C' && c == 'D'))
          )
        {
            letters.Pop();
        }
        else
        {
            letters.Push(c);
        }
    }

    return letters.Count();
}



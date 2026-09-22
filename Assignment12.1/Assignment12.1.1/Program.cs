Console.WriteLine(CanConstruct("a", "b")); // False
Console.WriteLine(CanConstruct("aa", "ab")); // False
Console.WriteLine(CanConstruct("aa", "aab")); // True

static bool CanConstruct(string ransomNote, string magazine)
{

    int[] letterFreq = new int[26];

    foreach (char c in magazine)
    {
        letterFreq[c - 'a']++;
    }

    foreach (char c in ransomNote)
    {
        letterFreq[c - 'a']--;
    }

    foreach (int leftOver in letterFreq)
    {
        if (leftOver < 0)
            return false;
    }

    return true;
}

Console.WriteLine(IsAnagram("anagram", "nagaram")); // true
Console.WriteLine(IsAnagram("rat", "car")); // false

bool IsAnagram(string s, string t)
{
    Dictionary<char, int> letters = [];

    foreach(char c in s)
    {
        if(!letters.ContainsKey(c))
        {
            letters[c] = 1;
        }
        else
        {
            letters[c]++;
        }
    }

    foreach (char c in t)
    {
        if (letters.ContainsKey(c))
        {
            letters[c]--;

            if (letters[c] == 0)
            {
                letters.Remove(c);
            }
        }
        else
        {
            return false;
        }
    }

    return letters.Count() == 0;
}
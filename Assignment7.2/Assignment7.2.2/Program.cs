Console.WriteLine(ReverseVowels("IceCreAm"));
Console.WriteLine(ReverseVowels("leetcode"));


static string ReverseVowels(string s)
{
    char[] letters = s.ToCharArray();
    int l = 0, r = s.Length - 1;

    while(l < r)
    {
        if (_IsVowel(letters[l]) && _IsVowel(letters[r]))
        {
            
            (letters[l], letters[r]) = (letters[r], letters[l]);
            l++;
            r--;
        }
        else
        {
            l = _IsVowel(letters[l]) ? l : l + 1;
            r = _IsVowel(letters[r]) ? r : r - 1;
        }
    }

    return new string(letters);
}

static bool _IsVowel(char c)
{
    return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
         || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
}
Console.WriteLine(IsPalindrome("RADaR")); // true
Console.WriteLine(IsPalindrome("A man, a plan, a canal, Panama!")); // true
Console.WriteLine(IsPalindrome("RADA")); // false
Console.WriteLine(IsPalindrome("a")); // true
Console.WriteLine(IsPalindrome("Yo, Banana Boi!")); // false
Console.WriteLine(IsPalindrome("Ma'am")); // true


static bool IsPalindrome(string s)
{
    string stripped = string.Concat(s.Where(char.IsLetterOrDigit)).ToLower();

    return RIsPalindrome(stripped, 0, stripped.Length - 1);
}

static bool RIsPalindrome(string s, int l, int r)
{
    // base case
    if(l >= r)
    {
        return true; // string of size 0 or 1 is a palindrome
    }

    // recurive case (only check the l and r pointers for equality)
    return (s[l] == s[r]) && RIsPalindrome(s, l + 1, r - 1);
}
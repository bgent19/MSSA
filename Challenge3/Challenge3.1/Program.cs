Console.Write("Type a word or phrase (terminated by ENTER): ");
string text = Console.ReadLine();

Console.WriteLine($"Was that a palindrome? {IsPalindrome(text)}");


static bool IsPalindrome(string s)
{

    // clean text -> regex [a-zA-Z0-9]*
    string r = new string(s.Where(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c)).ToArray());
    r = r.ToLower();

    int len = r.Length;
    int half = len / 2;

    for(int i = 0; i < half; ++i)
    {
        if (r[i] != r[len - 1 - i])
        {
            return false;
        }

    }

    return true;
}
Console.WriteLine(LengthOfLastWord("Hello World"));                 // 5
Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  ")); // 4
Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));       // 6

static int LengthOfLastWord(string s)
{
    int length = 0;

    for(int p = s.Length - 1;  p > 0; p--) // look through string in reverse order
    {
        if (s[p] != ' ') // This is part of last word
        {
            length++;
        }
        else if (length > 0) // Only true once whitespace found after counting last word
        {
            return length;
        }
    }

    return length; // 1 word with no leading whitespace case
}
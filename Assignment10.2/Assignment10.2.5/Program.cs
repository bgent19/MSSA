// Mock data sources: sorted character arrays with their targets (the three examples).
char[] letters1 = { 'c', 'f', 'j' };
char target1 = 'a';   // expected output: 'c'
Console.WriteLine(NextGreatestLetter(letters1, target1));

char[] letters2 = { 'c', 'f', 'j' };
char target2 = 'c';   // expected output: 'f'
Console.WriteLine(NextGreatestLetter(letters2, target2));

char[] letters3 = { 'x', 'x', 'y', 'y' };
char target3 = 'z';   // expected output: 'x'
Console.WriteLine(NextGreatestLetter(letters3, target3));


char NextGreatestLetter(char[] letters, char target)
{
    char result = letters[0];

    int l = 0,
        r = letters.Length,
        m = (l + r) / 2;

    while (l < r)
    {
        if (letters[m] < target)
        {
            l = m + 1;
        }
        else
        {
            r = m;
        }

        m = (l + r) / 2;
    }

    while (m < letters.Length && letters[m] == target)
    {
        m++;
    }

    if (m == letters.Length)
    {
        return result;
    }

    return letters[m];
}

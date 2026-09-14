Console.WriteLine(MaxNumberOfBalloons("nlaebolko")); // expect: 1
Console.WriteLine(MaxNumberOfBalloons("loonbalxballpoon")); // expect: 2
Console.WriteLine(MaxNumberOfBalloons("mssa")); // expect: 0

int MaxNumberOfBalloons(string text)
{
    string balloon = "balloon";

    Dictionary<char, int> balloons = [];
    foreach (char c in balloon)
    {
        balloons[c] = 0;
    }

    foreach (char c in text)
    {
        if (balloon.Contains(c))
        {
            balloons[c]++;
        }
    }

    int result = int.MaxValue;
    foreach ((char c, int i) in balloons)
    {
        if (c == 'l' || c == 'o')
        {
            result = Math.Min(result, i / 2);

        }
        else
        {
            result = Math.Min(result, i);
        }
    }

    return result;
}

using System.Text;

Console.WriteLine(MergeAlternately("abc", "pqr"));
Console.WriteLine(MergeAlternately("ab", "pqrs"));
Console.WriteLine(MergeAlternately("abcd", "pq"));

static string MergeAlternately(string word1, string word2)
{
    StringBuilder result = new(word1.Length + word2.Length);

    int i = 0, j = 0;

    while (i < word1.Length && j < word2.Length)
    {
        result.Append([word1[i++], word2[j++]]);
    }

    while (i < word1.Length)
    {
        result.Append(word1[i++]);
    }

    while (j < word2.Length)
    {
        result.Append(word2[j++]);
    }

    return result.ToString();
}
using System.Text;

Console.WriteLine(EvenNumbers(0, 100));


static string EvenNumbers(int min, int max)
{
    StringBuilder sb = new();

    // find first even number from min(> 0)
    if (min <= 0)
        min = 2;
    else if ((min % 2) != 0)
        ++min;

    for(int i = min; i < max; i += 2)
    {
        sb.AppendFormat("{0} ", i);
    }

    return sb.ToString();
}
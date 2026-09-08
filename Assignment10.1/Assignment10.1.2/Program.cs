List<string> results = (List<string>)GenerateParenthesis(5);

Console.WriteLine("n = 5");

foreach(string answer in results)
{
    Console.WriteLine(answer);
}


IList<string> GenerateParenthesis(int n)
{ 
    return recursiveGenPar("", 2 * n, 0);
}

// Weight = # of '(' minus # of ')'
IList<string> recursiveGenPar(string soFar, int numLeft, int weight)
{
    if (numLeft == 0)
    {
        return [soFar];
    }

    List<string> results = [];

    // add '('
    if (weight < numLeft) // if this is false, it means there arent enough spaces left to add the required ')'
    {
        results.AddRange(recursiveGenPar(soFar + '(', numLeft - 1, weight + 1));
    }

    // add ')'

    if (weight > 0) // If this is false, it means there isn't any remanining '(' to the left of a new ')'
    {
        results.AddRange(recursiveGenPar(soFar + ')', numLeft - 1, weight - 1));
    }


    return results;
}

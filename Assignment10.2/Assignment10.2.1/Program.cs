// Mock data source: list of numbers to filter for positives.
List<int> numbers = new List<int> { 2, -1, 3, -3, 10, -200 };

var numQuery = from num in numbers
               where (num > 0)
               select num;

Console.WriteLine(string.Join(", ", numQuery));
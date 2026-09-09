// Mock data source: list of numbers to filter for values greater than 80.

Random rand = new();

List<int> numbers = new List<int> { 55, 200, 740, 76, 230, 482, 95 };

for(int i = 0; i < 7; i++)
{
    numbers.Add(rand.Next(0, 1000));
}

Console.WriteLine(string.Join(", ", numbers));

var numQuery = from num in numbers
               where num > 80
               select num;

Console.WriteLine(string.Join(", ", numQuery));
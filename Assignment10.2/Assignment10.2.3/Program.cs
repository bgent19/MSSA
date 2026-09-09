// Mock data source: cities to search, plus the starting and ending characters.
List<string> cities = new List<string>
{
    "ROME",
    "LONDON",
    "NAIROBI",
    "CALIFORNIA",
    "ZURICH",
    "NEW DELHI",
    "AMSTERDAM",
    "ABU DHABI",
    "PARIS"
};

char startCharacter = 'A';
char endCharacter = 'M';

var cityQuery = from city in cities
                where (city.First() == startCharacter && city.Last() == endCharacter)
                select city;

Console.WriteLine(string.Join(", ", cityQuery));

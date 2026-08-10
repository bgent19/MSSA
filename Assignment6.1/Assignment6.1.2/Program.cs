


LinkedList<House> myList = new();

myList.AddLast(new House() { HouseNumber = 1, StreetName = "Winning Drive", TypeOfHouse = "Facility" });
myList.AddLast(new House() { HouseNumber = 2, StreetName = "First Loser Lane", TypeOfHouse = "Sad" });

Console.WriteLine(SearchByNumber(myList, 2));
Console.WriteLine(SearchByNumber(myList, 3));

House? SearchByNumber(LinkedList<House> l, int num)
{
    foreach (House h in myList)
    {
        if (h.HouseNumber == num)
        {
            return h;
        }

    }

    return null;
}

class House
{
    public int HouseNumber { get; set; }
    public string? StreetName { get; set; }

    public string? TypeOfHouse { get; set; }

    public override string ToString()
    {
        return $"{HouseNumber} {StreetName} ({TypeOfHouse})";
    }
}


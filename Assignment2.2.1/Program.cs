Labrador Buoy = new Labrador()
{
    id = 1,
    name = "Buoy",
    color = "Golden",
    sex = 'F',
    dateOfBirth = new DateTime(2024, 11, 10),
    isFixed = true,
    lovesWater = false,
    favoriteToy = "Ball",
};

Buoy.DoATrick();


class Dog
{
    public int id;
    public required string name;
    public char sex;
    public DateTime dateOfBirth;
    public bool isFixed;

    public virtual void DoATrick()
    {
        Console.WriteLine($"{name} is doing a trick!");
    }
}

class Retriever : Dog
{
    public string? color;
    public bool isGoodDog;
}

class Terrier : Dog
{
    public string? coatLength;
    public bool sheds;
}

class Labrador : Retriever
{
    public string? favoriteToy;
    public bool lovesWater;

    public override void DoATrick()
    {
        Console.WriteLine($"{name} is fetching the {favoriteToy}!");
    }
}

class ChesapeakeBayRetriever : Retriever
{
    public string? coatType;
    public bool isFriendly;

    public override void DoATrick()
    {
        Console.WriteLine($"{name} is swimming in the water!");
    }
}

class Airedale : Terrier
{
    public string? beardLength;
    public bool isIndependent;

    public override void DoATrick()
    {
        Console.WriteLine($"{name} is showing off {(sex == 'M' ? "his" : "her")} beard!");
    }
}

class JackRussell : Terrier
{
    public string? energyLevel;
    public bool isVocal;

    public override void DoATrick()
    {
        Console.WriteLine($"{name} is jumping high in the air!");
    }
}


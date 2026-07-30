Customer c = new() { IDNO = 1001, Name = "James", Usage=800 };

Console.WriteLine(c);

c.PrintCharges();





public class Customer
{
    public int IDNO { get; set; }
    public string Name { get; set; }
    public int Usage { get; set; }

    public override string ToString()
    {
        return $"Customer IDNO: {IDNO}{Environment.NewLine}" +
               $"Customer Name: {Name}{Environment.NewLine}" +
               $"unit Consumed: {Usage}";
    }

    public void PrintCharges()
    {
        Tier[] tiers = [new Tier { limit = 199, rate = 1.20m},
                        new Tier { limit = 201, rate = 1.50m}, // 400 - 199
                        new Tier { limit = 200, rate = 1.80m}, // 600 - 400
                        new Tier { limit = int.MaxValue, rate = 2.00m}];

        decimal chargeAmount = 0, surchargeAmount = 0;
        int usageLeft = Usage;

        foreach(Tier t in tiers)
        {
            int tierAmount;
            if(usageLeft > t.limit)
            {
                tierAmount = t.limit;
            }
            else // Everything left goes in this tier
            {
                tierAmount = usageLeft;
            }

            chargeAmount += tierAmount * t.rate;
            usageLeft -= tierAmount;

            if(usageLeft <= 0)
            {
                break;
            }
        }

        if(chargeAmount > 400)
        {
            surchargeAmount = 0.15m * chargeAmount;
        }

        Console.WriteLine($"Amount Charged: {chargeAmount:C}");
        Console.WriteLine($"Surcharge Amount: {surchargeAmount:C}");
        Console.WriteLine($"Ttoal Amount Due: {(chargeAmount + surchargeAmount):C}");
    }
}

public class Tier
{
    public int limit;
    public decimal rate;
}
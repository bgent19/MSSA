namespace Assignment3._4._1.Models
{
    public enum RoastLevel
    {
        Light,
        Medium,
        Dark
    }

    public class Coffee : Beverage
    {
        public override string Category => "Coffee";

        public RoastLevel Roast { get; set; } = RoastLevel.Medium;
        public int EspressoShots { get; set; } = 1;
        public bool HasMilk { get; set; }
    }
}

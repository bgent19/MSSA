namespace Assignment3._4._1.Models
{
    public enum BeverageSize
    {
        Small,
        Medium,
        Large
    }

    public abstract class Beverage
    {
        public string Name { get; set; } = string.Empty;
        public BeverageSize Size { get; set; } = BeverageSize.Medium;
        public decimal Price { get; set; }

        public abstract string Category { get; }
    }
}

namespace Assignment11._3
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public List<Movie> Movies { get; set; } = new();

        public override string ToString() => Name;
    }
}

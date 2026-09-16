namespace Assignment11._3
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public int ReleaseYear { get; set; }

        public string Rating { get; set; } = "";

        public int GenreId { get; set; }

        public Genre? Genre { get; set; }

        public override string ToString() => $"{Title} ({ReleaseYear})";
    }
}

using Microsoft.EntityFrameworkCore;

namespace Assignment11._3
{
    public class MovieContext : DbContext
    {
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Movie> Movies => Set<Movie>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // movies.db is created next to the .exe on first run.
            string dbPath = Path.Combine(AppContext.BaseDirectory, "movies.db");
            options.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            // Seed data: inserted when the database is first created.
            // Seeded rows must have explicit Ids so EF Core can track them.
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Comedy" },
                new Genre { Id = 3, Name = "Drama" },
                new Genre { Id = 4, Name = "Sci-Fi" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Die Hard", ReleaseYear = 1988, Rating = "R", GenreId = 1 },
                new Movie { Id = 2, Title = "Mad Max: Fury Road", ReleaseYear = 2015, Rating = "R", GenreId = 1 },
                new Movie { Id = 3, Title = "Groundhog Day", ReleaseYear = 1993, Rating = "PG", GenreId = 2 },
                new Movie { Id = 4, Title = "Superbad", ReleaseYear = 2007, Rating = "R", GenreId = 2 },
                new Movie { Id = 5, Title = "The Shawshank Redemption", ReleaseYear = 1994, Rating = "R", GenreId = 3 },
                new Movie { Id = 6, Title = "Forrest Gump", ReleaseYear = 1994, Rating = "PG-13", GenreId = 3 },
                new Movie { Id = 7, Title = "Blade Runner", ReleaseYear = 1982, Rating = "R", GenreId = 4 },
                new Movie { Id = 8, Title = "Interstellar", ReleaseYear = 2014, Rating = "PG-13", GenreId = 4 }
            );
        }
    }
}

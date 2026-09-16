using Microsoft.EntityFrameworkCore;

namespace Assignment11._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGenres();
        }

        // ---------------------------------------------------------------
        // Loading helpers
        // ---------------------------------------------------------------

        private void LoadGenres()
        {
            using var db = new MovieContext();
            var genres = db.Genres.OrderBy(g => g.Name).ToList();

            lstGenres.DataSource = null;
            lstGenres.DataSource = genres;

            // The combo box on the movie side needs its own copy of the list.
            cboMovieGenre.DataSource = null;
            cboMovieGenre.DataSource = genres.ToList();

            LoadMoviesForSelectedGenre();
        }

        private void LoadMoviesForSelectedGenre()
        {
            if (lstGenres.SelectedItem is not Genre genre)
            {
                lstMovies.DataSource = null;
                grpMovies.Text = "Movies";
                return;
            }

            using var db = new MovieContext();
            var movies = db.Movies
                .Where(m => m.GenreId == genre.Id)
                .OrderBy(m => m.Title)
                .ToList();

            lstMovies.DataSource = null;
            lstMovies.DataSource = movies;
            grpMovies.Text = $"Movies - {genre.Name} ({movies.Count})";
        }

        private void LoadAllMovies()
        {
            using var db = new MovieContext();
            var movies = db.Movies
                .Include(m => m.Genre)
                .OrderBy(m => m.Title)
                .ToList();

            lstMovies.DataSource = null;
            lstMovies.DataSource = movies;
            grpMovies.Text = $"Movies - All ({movies.Count})";
        }

        private void ClearMovieFields()
        {
            txtTitle.Clear();
            txtYear.Clear();
            txtRating.Clear();
            lstMovies.ClearSelected();

            // Default the genre combo to whatever genre is selected on the left.
            if (lstGenres.SelectedItem is Genre genre)
            {
                SelectGenreInCombo(genre.Id);
            }
        }

        private void SelectGenreInCombo(int genreId)
        {
            foreach (Genre g in cboMovieGenre.Items)
            {
                if (g.Id == genreId)
                {
                    cboMovieGenre.SelectedItem = g;
                    return;
                }
            }
        }

        // ---------------------------------------------------------------
        // Genre events
        // ---------------------------------------------------------------

        private void lstGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGenres.SelectedItem is Genre genre)
            {
                txtGenreName.Text = genre.Name;
            }

            LoadMoviesForSelectedGenre();
            ClearMovieFields();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string name = txtGenreName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please enter a genre name.", "Add Genre");
                return;
            }

            using var db = new MovieContext();

            if (db.Genres.Any(g => g.Name == name))
            {
                MessageBox.Show($"A genre named \"{name}\" already exists.", "Add Genre");
                return;
            }

            db.Genres.Add(new Genre { Name = name });
            db.SaveChanges();

            LoadGenres();
            txtGenreName.Clear();
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (lstGenres.SelectedItem is not Genre selected)
            {
                MessageBox.Show("Please select a genre to update.", "Update Genre");
                return;
            }

            string name = txtGenreName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Please enter a genre name.", "Update Genre");
                return;
            }

            using var db = new MovieContext();

            if (db.Genres.Any(g => g.Name == name && g.Id != selected.Id))
            {
                MessageBox.Show($"A genre named \"{name}\" already exists.", "Update Genre");
                return;
            }

            var genre = db.Genres.Find(selected.Id);
            if (genre == null) return;

            genre.Name = name;
            db.SaveChanges();

            LoadGenres();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (lstGenres.SelectedItem is not Genre selected)
            {
                MessageBox.Show("Please select a genre to delete.", "Delete Genre");
                return;
            }

            using var db = new MovieContext();

            int movieCount = db.Movies.Count(m => m.GenreId == selected.Id);
            if (movieCount > 0)
            {
                MessageBox.Show(
                    $"\"{selected.Name}\" still has {movieCount} movie(s). Delete or move them first.",
                    "Delete Genre");
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete genre \"{selected.Name}\"?",
                "Delete Genre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var genre = db.Genres.Find(selected.Id);
            if (genre == null) return;

            db.Genres.Remove(genre);
            db.SaveChanges();

            LoadGenres();
            txtGenreName.Clear();
        }

        // ---------------------------------------------------------------
        // Movie events
        // ---------------------------------------------------------------

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMovies.SelectedItem is not Movie movie) return;

            txtTitle.Text = movie.Title;
            txtYear.Text = movie.ReleaseYear.ToString();
            txtRating.Text = movie.Rating;
            SelectGenreInCombo(movie.GenreId);
        }

        private void btnShowAllMovies_Click(object sender, EventArgs e)
        {
            lstGenres.ClearSelected();
            LoadAllMovies();
        }

        private void btnClearMovie_Click(object sender, EventArgs e)
        {
            ClearMovieFields();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (!TryReadMovieFields(out string title, out int year, out string rating, out int genreId))
                return;

            using var db = new MovieContext();

            db.Movies.Add(new Movie
            {
                Title = title,
                ReleaseYear = year,
                Rating = rating,
                GenreId = genreId
            });
            db.SaveChanges();

            RefreshAfterMovieChange(genreId);
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (lstMovies.SelectedItem is not Movie selected)
            {
                MessageBox.Show("Please select a movie to update.", "Update Movie");
                return;
            }

            if (!TryReadMovieFields(out string title, out int year, out string rating, out int genreId))
                return;

            using var db = new MovieContext();

            var movie = db.Movies.Find(selected.Id);
            if (movie == null) return;

            movie.Title = title;
            movie.ReleaseYear = year;
            movie.Rating = rating;
            movie.GenreId = genreId;
            db.SaveChanges();

            RefreshAfterMovieChange(genreId);
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (lstMovies.SelectedItem is not Movie selected)
            {
                MessageBox.Show("Please select a movie to delete.", "Delete Movie");
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete \"{selected.Title}\"?",
                "Delete Movie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            using var db = new MovieContext();

            var movie = db.Movies.Find(selected.Id);
            if (movie == null) return;

            db.Movies.Remove(movie);
            db.SaveChanges();

            RefreshAfterMovieChange(selected.GenreId);
        }

        /// <summary>
        /// Validates the movie text boxes and combo box. Shows a message and
        /// returns false if anything is missing or invalid.
        /// </summary>
        private bool TryReadMovieFields(out string title, out int year, out string rating, out int genreId)
        {
            title = txtTitle.Text.Trim();
            rating = txtRating.Text.Trim();
            year = 0;
            genreId = 0;

            if (title == "")
            {
                MessageBox.Show("Please enter a title.", "Movie");
                return false;
            }

            if (!int.TryParse(txtYear.Text.Trim(), out year) || year < 1888 || year > DateTime.Today.Year)
            {
                MessageBox.Show("Please enter a valid release year.", "Movie");
                return false;
            }

            if (cboMovieGenre.SelectedItem is not Genre genre)
            {
                MessageBox.Show("Please select a genre.", "Movie");
                return false;
            }

            genreId = genre.Id;
            return true;
        }

        /// <summary>
        /// After adding/updating/deleting a movie, re-select the affected genre
        /// on the left so the user sees the change, then reload the movie list.
        /// </summary>
        private void RefreshAfterMovieChange(int genreId)
        {
            foreach (Genre g in lstGenres.Items)
            {
                if (g.Id == genreId)
                {
                    lstGenres.SelectedItem = g;
                    break;
                }
            }

            LoadMoviesForSelectedGenre();
            ClearMovieFields();
        }
    }
}

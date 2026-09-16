namespace Assignment11._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpGenres = new GroupBox();
            lstGenres = new ListBox();
            lblGenreName = new Label();
            txtGenreName = new TextBox();
            btnAddGenre = new Button();
            btnUpdateGenre = new Button();
            btnDeleteGenre = new Button();
            grpMovies = new GroupBox();
            lstMovies = new ListBox();
            btnShowAllMovies = new Button();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblYear = new Label();
            txtYear = new TextBox();
            lblRating = new Label();
            txtRating = new TextBox();
            lblMovieGenre = new Label();
            cboMovieGenre = new ComboBox();
            btnAddMovie = new Button();
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            btnClearMovie = new Button();
            grpGenres.SuspendLayout();
            grpMovies.SuspendLayout();
            SuspendLayout();
            //
            // grpGenres
            //
            grpGenres.Controls.Add(lstGenres);
            grpGenres.Controls.Add(lblGenreName);
            grpGenres.Controls.Add(txtGenreName);
            grpGenres.Controls.Add(btnAddGenre);
            grpGenres.Controls.Add(btnUpdateGenre);
            grpGenres.Controls.Add(btnDeleteGenre);
            grpGenres.Location = new Point(12, 12);
            grpGenres.Name = "grpGenres";
            grpGenres.Size = new Size(260, 470);
            grpGenres.TabIndex = 0;
            grpGenres.TabStop = false;
            grpGenres.Text = "Genres";
            //
            // lstGenres
            //
            lstGenres.FormattingEnabled = true;
            lstGenres.Location = new Point(12, 26);
            lstGenres.Name = "lstGenres";
            lstGenres.Size = new Size(236, 304);
            lstGenres.TabIndex = 0;
            lstGenres.SelectedIndexChanged += lstGenres_SelectedIndexChanged;
            //
            // lblGenreName
            //
            lblGenreName.AutoSize = true;
            lblGenreName.Location = new Point(12, 345);
            lblGenreName.Name = "lblGenreName";
            lblGenreName.Size = new Size(42, 15);
            lblGenreName.TabIndex = 1;
            lblGenreName.Text = "Name:";
            //
            // txtGenreName
            //
            txtGenreName.Location = new Point(12, 363);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(236, 23);
            txtGenreName.TabIndex = 2;
            //
            // btnAddGenre
            //
            btnAddGenre.Location = new Point(12, 400);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(72, 30);
            btnAddGenre.TabIndex = 3;
            btnAddGenre.Text = "Add";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += btnAddGenre_Click;
            //
            // btnUpdateGenre
            //
            btnUpdateGenre.Location = new Point(94, 400);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(72, 30);
            btnUpdateGenre.TabIndex = 4;
            btnUpdateGenre.Text = "Update";
            btnUpdateGenre.UseVisualStyleBackColor = true;
            btnUpdateGenre.Click += btnUpdateGenre_Click;
            //
            // btnDeleteGenre
            //
            btnDeleteGenre.Location = new Point(176, 400);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(72, 30);
            btnDeleteGenre.TabIndex = 5;
            btnDeleteGenre.Text = "Delete";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            btnDeleteGenre.Click += btnDeleteGenre_Click;
            //
            // grpMovies
            //
            grpMovies.Controls.Add(lstMovies);
            grpMovies.Controls.Add(btnShowAllMovies);
            grpMovies.Controls.Add(lblTitle);
            grpMovies.Controls.Add(txtTitle);
            grpMovies.Controls.Add(lblYear);
            grpMovies.Controls.Add(txtYear);
            grpMovies.Controls.Add(lblRating);
            grpMovies.Controls.Add(txtRating);
            grpMovies.Controls.Add(lblMovieGenre);
            grpMovies.Controls.Add(cboMovieGenre);
            grpMovies.Controls.Add(btnAddMovie);
            grpMovies.Controls.Add(btnUpdateMovie);
            grpMovies.Controls.Add(btnDeleteMovie);
            grpMovies.Controls.Add(btnClearMovie);
            grpMovies.Location = new Point(288, 12);
            grpMovies.Name = "grpMovies";
            grpMovies.Size = new Size(584, 470);
            grpMovies.TabIndex = 1;
            grpMovies.TabStop = false;
            grpMovies.Text = "Movies";
            //
            // lstMovies
            //
            lstMovies.FormattingEnabled = true;
            lstMovies.Location = new Point(12, 26);
            lstMovies.Name = "lstMovies";
            lstMovies.Size = new Size(560, 214);
            lstMovies.TabIndex = 0;
            lstMovies.SelectedIndexChanged += lstMovies_SelectedIndexChanged;
            //
            // btnShowAllMovies
            //
            btnShowAllMovies.Location = new Point(12, 246);
            btnShowAllMovies.Name = "btnShowAllMovies";
            btnShowAllMovies.Size = new Size(120, 26);
            btnShowAllMovies.TabIndex = 1;
            btnShowAllMovies.Text = "Show All Movies";
            btnShowAllMovies.UseVisualStyleBackColor = true;
            btnShowAllMovies.Click += btnShowAllMovies_Click;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 290);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title:";
            //
            // txtTitle
            //
            txtTitle.Location = new Point(80, 287);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(492, 23);
            txtTitle.TabIndex = 3;
            //
            // lblYear
            //
            lblYear.AutoSize = true;
            lblYear.Location = new Point(12, 322);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(32, 15);
            lblYear.TabIndex = 4;
            lblYear.Text = "Year:";
            //
            // txtYear
            //
            txtYear.Location = new Point(80, 319);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 5;
            //
            // lblRating
            //
            lblRating.AutoSize = true;
            lblRating.Location = new Point(220, 322);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(44, 15);
            lblRating.TabIndex = 6;
            lblRating.Text = "Rating:";
            //
            // txtRating
            //
            txtRating.Location = new Point(280, 319);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(100, 23);
            txtRating.TabIndex = 7;
            //
            // lblMovieGenre
            //
            lblMovieGenre.AutoSize = true;
            lblMovieGenre.Location = new Point(12, 354);
            lblMovieGenre.Name = "lblMovieGenre";
            lblMovieGenre.Size = new Size(42, 15);
            lblMovieGenre.TabIndex = 8;
            lblMovieGenre.Text = "Genre:";
            //
            // cboMovieGenre
            //
            cboMovieGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMovieGenre.FormattingEnabled = true;
            cboMovieGenre.Location = new Point(80, 351);
            cboMovieGenre.Name = "cboMovieGenre";
            cboMovieGenre.Size = new Size(300, 23);
            cboMovieGenre.TabIndex = 9;
            //
            // btnAddMovie
            //
            btnAddMovie.Location = new Point(12, 400);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(90, 30);
            btnAddMovie.TabIndex = 10;
            btnAddMovie.Text = "Add";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            //
            // btnUpdateMovie
            //
            btnUpdateMovie.Location = new Point(112, 400);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(90, 30);
            btnUpdateMovie.TabIndex = 11;
            btnUpdateMovie.Text = "Update";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            //
            // btnDeleteMovie
            //
            btnDeleteMovie.Location = new Point(212, 400);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(90, 30);
            btnDeleteMovie.TabIndex = 12;
            btnDeleteMovie.Text = "Delete";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            //
            // btnClearMovie
            //
            btnClearMovie.Location = new Point(312, 400);
            btnClearMovie.Name = "btnClearMovie";
            btnClearMovie.Size = new Size(90, 30);
            btnClearMovie.TabIndex = 13;
            btnClearMovie.Text = "Clear";
            btnClearMovie.UseVisualStyleBackColor = true;
            btnClearMovie.Click += btnClearMovie_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 494);
            Controls.Add(grpGenres);
            Controls.Add(grpMovies);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Library";
            Load += Form1_Load;
            grpGenres.ResumeLayout(false);
            grpGenres.PerformLayout();
            grpMovies.ResumeLayout(false);
            grpMovies.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpGenres;
        private ListBox lstGenres;
        private Label lblGenreName;
        private TextBox txtGenreName;
        private Button btnAddGenre;
        private Button btnUpdateGenre;
        private Button btnDeleteGenre;
        private GroupBox grpMovies;
        private ListBox lstMovies;
        private Button btnShowAllMovies;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblRating;
        private TextBox txtRating;
        private Label lblMovieGenre;
        private ComboBox cboMovieGenre;
        private Button btnAddMovie;
        private Button btnUpdateMovie;
        private Button btnDeleteMovie;
        private Button btnClearMovie;
    }
}

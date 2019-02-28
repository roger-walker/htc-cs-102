using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string movieName;
        private int releaseYear;

        public Movie (string name, int releaseYear)
        {
            this.movieName = name;
            this.releaseYear = releaseYear;
        }

        public void ShowMovie()
        {
            MessageBox.Show(movieName + Environment.NewLine + releaseYear);
        }
    }
}

using System;
using System.Collections.Generic;
namespace Lab_10_Movie_List
{
    public class Movie
    {
        #region fields
        private string _title;
        private string _category;
        #endregion

        #region properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        #endregion

        #region methods
        public Movie()
        {
        }

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public List<string> GetMovieCategories(List<Movie> movies)
        {
            List<string> categories = new List<string>();
            foreach (Movie movie in movies)
            {
                if (!categories.Contains(movie.Category))
                {
                    categories.Add(movie.Category);
                }
            }
            return categories;
        }

        public List<Movie> GetMoviesByCategory(List<Movie> movies, string selection)
        {
            List<Movie> moviesByCat = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.Category.ToLower() == selection.ToLower())
                {
                    moviesByCat.Add(movie);
                }
            }
            return moviesByCat;
        }

        public void PrintMoviesByCategory(List<Movie> movies)
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Title);
            }
        }
        #endregion
    }
}

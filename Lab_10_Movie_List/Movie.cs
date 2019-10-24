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

        public static List<string> GetMovieCategories(List<Movie> movies)
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

        public static int NumOfCategories(List<Movie> movies)
        {
            return GetMovieCategories(movies).Count;
        }

        public static void PrintMovieCategories(List<Movie> movies)
        {
            List<string> categories = new List<string>();
            int index = 0;
            categories = GetMovieCategories(movies);
            foreach (string element in categories)
            {
                index++;
                Console.Write($"{index}. ");
                Console.WriteLine(element);
            }
        }

        private static List<Movie> GetMoviesByCategory(List<Movie> movies, string selection)
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

        public static void PrintMoviesByCategory(List<Movie> movies, string selection)
        {
            // The CompareTo method wanted me to use StringComparison.Ordinal
            List<Movie> moviesByCat = new List<Movie>();
            moviesByCat = GetMoviesByCategory(movies, selection);
            moviesByCat.Sort(SortMovies);
            foreach (Movie movie in moviesByCat)
            {
                Console.WriteLine(movie.Title);
            }
        }

        public static int SortMovies(Movie movie1, Movie movie2)
        {
            return String.Compare(movie1.Title, movie2.Title);
        }
        #endregion
    }
}

// ===============================
// AUTHOR     : Jonathan Lubaway
// CREATE DATE: October 24th, 2019
// PURPOSE    : List Movies by category
// ===============================
using System;
using System.Collections.Generic;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie("The Nightmare Before Christmas", "Animated"),
                new Movie("Tucker and Dale Versus Evil", "Comedy"),
                new Movie("Interstellar", "Sci-Fi"),
                new Movie("Get Out", "Horror"),
                new Movie("Lilo & Stitch", "Animated"),
                new Movie("Airplane", "Comedy"),
                new Movie("IT Chapter One", "Horror"),
                new Movie("Grand Budapest Hotel", "Comedy"),
                new Movie("Spirited Away", "Animated"),
                new Movie("Kung Fu Hustle", "Comedy"),
                new Movie("Hitchhiker's Guide to the Galaxy", "Sci-Fi"),
                new Movie("A Quiet Place", "Horror"),
                new Movie("The Martian", "Sci-Fi"),
                new Movie("Coco", "Animated"),
                new Movie("Happy Death Day", "Horror"),
                new Movie("Matrix", "Sci-Fi"),
                new Movie("Cabin in the Woods", "Horror"),
                new Movie("Who Framed Roger Rabbit", "Sci-Fi"),
                new Movie("Scott Pilgrim", "Comedy"),
                new Movie("Shrek", "Animated")
            };

            Console.WriteLine("Hello, which category of movies would you like to look at?");
            Movie.PrintMovieCategories(movies);
            List<string> categories = Movie.GetMovieCategories(movies);

            int userInput = ParseRange(Movie.NumOfCategories(movies));
            Console.WriteLine();
            Movie.PrintMoviesByCategory(movies, categories[userInput]);
        }

        public static int ParseRange(int max)
        {
            int userInput = 0;
            bool check = int.TryParse(Console.ReadLine(), out userInput);

            if (check && userInput > 0 && userInput <= max)
            {
                userInput--;
                return userInput;
            }
            Console.WriteLine("\nPlease enter a valid number within range.");
            return ParseRange(max);

        }
    }
}

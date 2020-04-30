using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
    class Movie
    {
        //private fields
        private string title;
        private string category;
        private int categoryNumber;

        //public properties

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int CategoryNumber
        {
            get { return categoryNumber; }
            set { categoryNumber = value; }
        }

        // constructors

        public Movie(string _title, string _category, int _categoryNumber)
        {
            title = _title;
            category = _category;
            categoryNumber = _categoryNumber;
        }

        public Movie()
        {

        }

        //Methods

        public static void FillListMovies(List <Movie> movies)
        {
            movies.Add(new Movie("Black Panther", "drama", 1));
            movies.Add(new Movie("Citizen Kane", "drama", 1));
            movies.Add(new Movie("Frozen", "animated", 2));
            movies.Add(new Movie("Finding Nemo", "animated", 2));
            movies.Add(new Movie("Toy Story", "animated", 2));
            movies.Add(new Movie("Pet Sematary", "horror", 3));
            movies.Add(new Movie("It", "horror", 3));
            movies.Add(new Movie("The Conjuring", "horror", 3));
            movies.Add(new Movie("Star Wars: A New Hope", "sci-fi", 4));
            movies.Add(new Movie("Star Wars: The Empire Strikes Back", "sci-fi", 4));
            movies.Sort((x,y) => x.Title.CompareTo(y.Title));
        }
    }
}

using System;
using System.Collections.Generic;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                List<Movie> movies = new List<Movie>();
                Movie.FillListMovies(movies);

                string userChoice = GetSearchChoice("Would you like to select by category or number?  Type cateogy or number");
              
                if (userChoice == "category")
                {
                    string categoryChoice = GetUserInput("Which category would you like to see? drama, sci-fi, animated, or horror");

                    DisplayMovies(categoryChoice, movies);
                }
                else if (userChoice == "number")
                {
                    int numberChoice = GetCategoryNumber("Which category would you like to see more about? Enter a number \n 1. drama \n 2. animated \n 3. horror \n 4. sci-fi");
                    DisplayMoviebyNumber(numberChoice, movies);
                }


                keepGoing = KeepAsking(); 
            }
        }

        public static string GetUserInput(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine().ToLower().Trim();
                if (!string.IsNullOrEmpty(input) && (input == "horror" || input == "animated" || input == "sci-fi" || input == "drama"))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("That was invalid input, try again!");
                    continue;
                }

            }
        }

        public static int GetCategoryNumber(string message)
        {
            while (true)
            {
                int number = 0;

                try
                {

                    Console.WriteLine(message);
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a number. Try again");
                    continue;
                }
                if (number >= 1 && number <= 4)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Number is not between 1 and 4. Try again!");
                    continue;
                }
            }
         }


        public static string GetSearchChoice(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string choice = Console.ReadLine().ToLower().Trim();
                if (!String.IsNullOrEmpty(choice) && choice == "number" || choice == "category")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                    continue;
                }
            }
        }

        public static void DisplayMovies(string userChoice, List<Movie> movies)
        {
            foreach (Movie m in movies)
            {
                if (m.Category == userChoice)
                {
                    
                    Console.WriteLine(m.Title);
                }
            }

        }
        public static void DisplayMoviebyNumber(int numberChoice, List<Movie> movies)
        {
            foreach (Movie m in movies)
            {
                if(m.CategoryNumber == numberChoice)
                {
                    Console.WriteLine(m.Title);
                }
            }
        }
        public static bool KeepAsking()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue? y or n");
                string decision = Console.ReadLine().ToLower().Trim();
                if (decision == "y")
                {
                    return true;
                }
                if (decision == "n")
                {
                    Console.WriteLine("Have a great day! Goodbye");
                    return false;

                }
                else
                {
                    Console.WriteLine("Invalid input.  Try again!");
                    continue;
                }
            }
        }

    }
}

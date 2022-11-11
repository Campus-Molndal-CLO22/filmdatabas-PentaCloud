namespace MovieDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    using System.Xml.Linq;

    public class Movie
    {
        public int MovieId { get; }
        public string Title { get; }
        public int Year { get; }
        public string Category { get; }
        public string MainCharacter { get; }
        public string IMDBLink { get; }
        public List<Actor> Actors { get; }

        public Movie(string title)
        {
            this.Title = title;
            this.Actors = new List<Actor>();
        }

        public Movie(int movieId, string title, int year, string category, string mainCharacter, string IMDBLink)
        {
            this.MovieId = movieId;
            this.Title = title;
            this.Year = year;
            this.Category = category;
            this.MainCharacter = mainCharacter;
            this.IMDBLink = IMDBLink;
            this.Actors = new List<Actor>();
        }
        public Movie()
        {
            
            Console.WriteLine("Title?");
            Title = Console.ReadLine();
            Console.WriteLine("Year?");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Category?");
            Category = Console.ReadLine();
            Console.WriteLine("Main Character?");
            MainCharacter = Console.ReadLine();
            Console.WriteLine("IMDBLink?");
            IMDBLink = Console.ReadLine();
        }
    }
}
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
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public string MainCharacter { get;set; }
        public string IMDBLink { get; set; }
       // public List<Actor> Actors { get; set; }
        public Movie()
        {
            Console.WriteLine("MovieId");
            MovieId = int.Parse(Console.ReadLine());
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

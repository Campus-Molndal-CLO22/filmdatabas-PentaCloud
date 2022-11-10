namespace MovieDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class Movie
    {
        public int MovieId { get; }
        public string Title { get; }
        public int Year { get; }
        public string Category { get; }
        public string MainCharacter { get; }
        public string IMDBLink { get; }
        public List<Actor> Actors { get; }

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
    }

}
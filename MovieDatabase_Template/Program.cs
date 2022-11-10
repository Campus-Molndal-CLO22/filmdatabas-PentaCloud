using MovieDatabase;
using MovieDatabase_Template;
using MySql.Data.MySqlClient;
using System.Data;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Movie fans!");

        // Börja med att lägga till Nuget för MySQL
        // Sen kan ni kolla på koden ;)

        // Uppgift:
        // Skapa en eller flera tabeller som ska
        // innehålla information om filmer och skådespelare

        using MovieCrud movieCrud = CreateMovieCrud();
        List<Movie> movies = movieCrud.GetMovies();
        foreach (Movie movie in movies)
        {
            Console.WriteLine($"Movie {movie.Title} was released {movie.Year} and main actor is {movie.MainCharacter}.");
            foreach (Actor actor in movie.Actors)
            {
                Console.WriteLine($"-- {actor.FirstName} {actor.LastName}.");
            }
        }

        List<Actor> actors = movieCrud.GetActors();
        foreach (Actor actor in actors)
        {
            Console.WriteLine($"Actor {actor.FirstName} {actor.LastName} was born on year {actor.BornYear}.");
            foreach (Movie movie in actor.Movies)
            {
                Console.WriteLine($"-- {movie.Title} ({movie.Year}).");
            }
        }
    }

    private static MovieCrud CreateMovieCrud()
    {
        string server = "ns8.inleed.net";
        string user = "s60127_Nora";
        string password = "gOrplXLsSsassPvu";
        string database = "s60127_PentaCloud";
        return new MovieCrud(server, user, password, database);
    }

}

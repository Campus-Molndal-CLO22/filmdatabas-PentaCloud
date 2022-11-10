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

        Menu.MainMenu(CreateMovieCrud());
    }

    private static MovieCrud CreateMovieCrud()
    {

        return new MovieCrud(server, user, password, database);
    }

}

using MovieDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase_Template
{
    internal class Menu
    {
        public static void MainMenu(MovieCrud movieCrud)
        {
            Console.Clear();
            bool applicationRunning = true;
            while (applicationRunning)
            {
                Console.WriteLine(
                            "|****************************************|\r\n" +
                            "|               Movie Database           |\r\n" +
                            "|****************************************|\r\n" +
                            "|1. List Movies                          |\r\n" +
                            "|2. List Actors                          |\r\n" +
                            "|3. Add Movie                            |\r\n" +
                            "|4. Add Actor                            |\r\n" +
                            "|5. Associate Actor with Movie           |\r\n" +
                            "|6. Delete Movie                         |\r\n" +
                            "|7. Delete Actor                         |\r\n" +
                            "|8. Remove Actor from Movie              |\r\n" +
                            "|9. Search for Movie                     |\r\n" +
                            "|10.Search for Actor                     |\r\n" +
                            "|0. Exit                                 |\r\n" +
                            "|****************************************|");
                Console.Write(" Select an option: ");
                int choice = InputUtil.SafeReadInt(1, 10, true);
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        List<Movie> allMovies = movieCrud.GetMovies();
                        foreach (Movie listMovie in allMovies)
                        {
                            Console.WriteLine($"Movie {listMovie.Title} was released {listMovie.Year} and main actor is {listMovie.MainCharacter}.");
                            foreach (Actor listMovieActor in listMovie.Actors)
                            {
                                Console.WriteLine($"-- {listMovieActor.FirstName} {listMovieActor.LastName}.");
                            }
                        }
                        break;
                    case 2:
                        List<Actor> actors = movieCrud.GetActors();
                        foreach (Actor listActor in actors)
                        {
                            Console.WriteLine($"Actor {listActor.FirstName} {listActor.LastName} was born on year {listActor.BornYear}.");
                            foreach (Movie listFeaturingMovie in listActor.Movies)
                            {
                                Console.WriteLine($"-- {listFeaturingMovie.Title} ({listFeaturingMovie.Year}).");
                            }
                        }
                        break;
                    case 3:
                        movieCrud.AddMovie();
                        break;
                    case 4:
                        movieCrud.AddActor();
                        break;
                    case 5:
                        movieCrud.AddActorToMovie();
                        break;
                    case 6:
                        movieCrud.DeleteMovie();
                        break;
                    case 7:
                        movieCrud.DeleteActor();
                        break;
                    case 8:
                        movieCrud.RemoveActorFromMovie();
                        break;
                    case 9: 
                        movieCrud.SearchForMovies();
                        break;
                    case 10: 
                        movieCrud.SearchForActors();
                        break;
                    case 0:
                        applicationRunning = false;
                        break;
                }
            }
            Console.WriteLine("Bye bye");
            Environment.Exit(0);
        }
    }
}

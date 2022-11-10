namespace MovieDatabase_Template
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MovieDatabase;
    using MySql.Data.MySqlClient;

    public class MovieCrud
    {
        string connString = "";
        MySqlConnection cnn = null;

        public MovieCrud(string connString)
        {
            //Connection behövs för att kunna kommunicera med databaen
            cnn = new MySqlConnection(connString);
            // Öppna kopplingen
            cnn.Open();
        }
        

        public DataTable Query(string sql)
        {
            var dt = new DataTable();
            var adt = new MySqlDataAdapter(sql, cnn);
            adt.Fill(dt);
            return dt;
        }
        public bool CheckIfMovieExists(Movie movie)
        {
            var dt = new DataTable();
            string sql = $"SELECT * FROM Movies WHERE Title = '{movie.Title}' ";
            dt = Query(sql);
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public bool CheckIfActorExists(Actor actor)
        {
            var dt = new DataTable();
            string sql = $"SELECT * FROM Actors WHERE FirstName = '{actor.FirstName}' AND LastName = '{actor.LastName}'";
            dt = Query(sql);
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        public void AddMovie()
        {
            bool exists = false;
            Movie movie = new Movie();
            string sql = $"INSERT INTO `Movies`(`MovieId`,`Title`, `Year`, `Category`,`MainCharacter`,`IMDBLink`) VALUES ({movie.MovieId},'{movie.Title}',{movie.Year},'{movie.Category}','{movie.MainCharacter}','{movie.IMDBLink}')";
            exists = CheckIfMovieExists(movie);

            if (exists == false)
            {
                using var cmd = new MySqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
            }
            else Console.WriteLine("Den filmen fanns redan");
            // Kolla om filmen redan finns, uppdatera i så fall
            // Om inte, lägg till filmen i databasen
            // Lägg till skådespelarna i databasen
            // Lägg till relationen mellan filmen och skådespelarna i databasen
        }
        public void DeleteMovie()
        {
            
            Console.WriteLine("Enter title of the Movie you want to delete");
            
            string movieTitle = Console.ReadLine();
            string sql = $"DELETE FROM `Movies` WHERE `Title` ='{movieTitle}'";
            using var cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            
            
            // Ta bort filmen från databasen
            // Ta bort alla relationer mellan filmen och skådespelarna från databasen
        }
        public void DeleteActor()
        {
            Console.WriteLine("Enter the Name of the Actor you want to delete");
            Console.Write("FirstName:");
            string actorFirstName = Console.ReadLine();
            Console.Write("LastName:");
            string actorLastName = Console.ReadLine();
            string sql = $"DELETE FROM `Actors` WHERE `FirstName` ='{actorFirstName}' AND `LastName` = '{actorLastName}'";
            using var cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            // Ta bort skådespelaren från databasen
            // Ta bort alla relationer mellan skådespelaren och filmerna från databasen
        }
        public void AddActor()
        {
            bool exists = false;
            Actor actor = new Actor();
            string sql = $"INSERT INTO `Actors`(`Id`,`FirstName`, `LastName`, `BornYear`) VALUES ({actor.Id},'{actor.FirstName}','{actor.LastName}','{actor.BornYear}')";
            exists = CheckIfActorExists(actor);

            if (exists == false)
            {
                using var cmd = new MySqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
            }
            else Console.WriteLine("Den filmen fanns redan");

            // Kolla om skådespelaren finns i databasen
            // Uppdatera i så fall annars
            // Lägg till skådespelaren i databasen
        }

    }
}

//        public void AddActorToMovie(Actor actor, Movie movie)
//        {
//            // Kolla om relationen finns i databasen, i så fall är du klar
//            // Annars lägg till relationen mellan filmen och skådespelaren i databasen
//        }

//        public List<Movie> GetMovies()
//        {
//            // Hämta alla filmer från databasen
//            // Hämta alla skådespelare från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Skapa en lista med filmer
//            // Lägg till skådespelarna till filmerna
//            // Returnera listan med filmer
//        }

//        public List<Movie> GetMoviesContaining(string search)
//        {
//            // Hämta alla matchande filmer från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla relaterade skådespelare från databasen
//            // Skapa en lista med filmer
//            // Lägg till skådespelarna till filmerna
//            // Returnera listan med filmer
//        }

//        public List<Movie> GetMoviesFromYear(int year)
//        {
//            // Hämta alla matchande filmer från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla relaterade skådespelare från databasen
//            // Skapa en lista med filmer
//            // Lägg till skådespelarna till filmerna
//            // Returnera listan med filmer
//        }

//        public List<Movie> GetMovie(int Id)
//        {
//            // Hämta matchande film från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla relaterade skådespelare från databasen
//            // Skapa en lista med filmer
//            // Lägg till skådespelarna till filmerna
//            // Returnera listan med filmer
//        }

//        public List<Movie> GetMovie(string name)
//        {
//            // Hämta matchande film från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla relaterade skådespelare från databasen
//            // Skapa en lista med filmer
//            // Lägg till skådespelarna till filmerna
//            // Returnera listan med filmer
//        }


//        public List<Actor> GetActors()
//        {
//            // Hämta alla skådespelare från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla matchande filmer från databasen
//            // Skapa en lista med skådespelare
//            // Lägg till filmerna till skådespelarna
//            // Returnera listan med skådespelare
//        }

//        public List<Actor> GetActorsInMovie(Movie movie)
//        {
//            // Hämta alla skådespelare från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla matchande filmer från databasen
//            // Skapa en lista med skådespelare
//            // Lägg till filmerna till skådespelarna
//            // Returnera listan med skådespelare
//        }

//        public List<Movie> GetMoviesWithActor(Actor actor)
//        {
//            // Hämta alla skådespelare från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla matchande filmer från databasen
//            // Skapa en lista med skådespelare
//            // Lägg till filmerna till skådespelarna
//            // Returnera listan med skådespelare
//        }

//        public List<Movie> GetMoviesWithActor(string actorName)
//        {
//            // Hämta alla skådespelare från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla matchande filmer från databasen
//            // Skapa en lista med skådespelare
//            // Lägg till filmerna till skådespelarna
//            // Returnera listan med skådespelare
//        }

//        public List<Movie> GetMoviesWithActor(int actorId)
//        {
//            // Hämta alla skådespelare från databasen
//            // Hämta alla relationer mellan filmer och skådespelare från databasen
//            // Hämta alla matchande filmer från databasen
//            // Skapa en lista med skådespelare
//            // Lägg till filmerna till skådespelarna
//            // Returnera listan med skådespelare
//        }

//        


//    }
//}

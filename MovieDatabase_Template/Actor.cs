namespace MovieDatabase
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BornYear { get; set; }
        public List<Movie> Movies { get; }

        public Actor(int id, string firstName, string lastName, int bornYear)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BornYear = bornYear;
            this.Movies = new List<Movie>(); 
        }

        public Actor(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Movies = new List<Movie>();
        }
        public Actor()
        {
            Console.WriteLine("FirstName?");
            FirstName = Console.ReadLine();
            Console.WriteLine("LastName?");
            LastName = Console.ReadLine();
            Console.WriteLine("BornYear?");
            BornYear = int.Parse(Console.ReadLine());
        }
    }
   
}

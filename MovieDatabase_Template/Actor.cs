namespace MovieDatabase
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BornYear { get; set; }

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

using MovieDatabase_Template;
using MySql.Data.MySqlClient;

Console.WriteLine("Hello, Movie fans!");

// Börja med att lägga till Nuget för MySQL
// Sen kan ni kolla på koden ;)

// Uppgift:
// Skapa en eller flera tabeller som ska
// innehålla information om filmer och skådespelare

var connString =  @"Server=ns8.inleed.net;Database=s60127_PentaCloud;Uid=;Pwd=;";
  
MovieCrud movieCrud = new(connString);

using var cnn = new MySqlConnection(connString);
// Öppna kopplingen

cnn.Open();
string sql = "SELECT * FROM Movies";
using var cmd = new MySqlCommand(sql, cnn);

using var reader = cmd.ExecuteReader();

while (reader.Read())
{
    Console.WriteLine($"{reader["Title"]}: {reader["Year"]} : {reader["Category"]}");

}

movieCrud.DeleteActor();
cnn.Close();
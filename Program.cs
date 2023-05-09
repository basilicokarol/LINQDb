// See https://aka.ms/new-console-template for more information
using SQLite;
//27/4/2023
//connessione al db


SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<Artist>("select * from artists");
Console.WriteLine($"in questa tabella ci sono {tblArtists.Count}record");


//language INtegrate Query
//LINQ

//4/5/2023
//foreach si passa tutti i record e mi scrive il nome

/*int x=0;
Artists[] vect= new[tblArtists.Count];


while(x<tblArtists.Count)
{
    vect[x] = tblArtists[x].Name;
    x++;
}
*/

var temporanea = tblArtists.OrderByDescending(x => x.Name).Max( y => y.ArtistId);

foreach(var record in tblArtists)
{
    Console.WriteLine( $"{record.Name}");
}

Console.WriteLine( $"{temporanea}");


// Fine del main --- inizio delle dichiarazioni ---
public class Artist
{
    public int ArtistId{get;set;}
    public string Name{get;set;}

}

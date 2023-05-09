# karol.basilico.4h.LINQDb
//
- Come prima cosa bisogna creare una cartella con il nome corretto
- successivamente bisogna inserire la cartella su Visual Studio
- dobbiamo creare un nuovo progetto con il comando "dotnet new console"
- dal web scarichiamo chinook.db :
 Puoi installare e utilizzare il database di esempio Chinook utilizzando:
 Un'installazione locale di YugabyteDB.
 Per installare YugabyteDB, fare riferimento a Quick Start.
 Utilizzo di cloud shell o di una shell client per connettersi a un cluster in YugabyteDB Managed.
 Fare riferimento a Connettersi ai cluster in YugabyteDB Managed.
 Per   iniziare con YugabyteDB Managed, fare riferimento a Avvio rapido.
 In entrambi i casi, si utilizza la CLI di YugabyteDB SQL shell (ysqlsh) per interagire con YugabyteDB utilizzando YSQL 
- link per scaricarlo https://www.sqlitetutorial.net/sqlite-sample-database/
Download SQLite sample database
You can download the SQLite sample database using the following link.

Download SQLite sample database
-successivamente inserire il chinook nella cartella di Visual Studio
- dopo questi passaggi si può iniziare a scrivere il codice
- primo comando da aggiungere è " using SQLite;"
- poi nel terminale aggiungere questa libreria che sarà fondamentale per il programma:

  PS C:\Users\Karol\Desktop\basilico.karol.4h.LINQDb> dotnet add package sqlite-net-pcl
  
-come primo comando scrivere scrivere la riga di codice che ci permette di accedere alla libreria
###  
  SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
###    
-poi inserisci la libreria che ci permette di selezionare quello che vogliamo dal DB :
###   
  var tblArtists = cn1.Query<Artist>("select * from artists");
###   
-riga di codice usiamo il comando che ci permette di ordinare gli ID degli artisti:
 ###
  var temporanea = tblArtists.OrderByDescending(x => x.Name).Max( y => y.ArtistId);
 ### 
-  fare il foreach e poi si stampiamo il numero dei record
 ###
 foreach(var record in tblArtists)
{
    Console.WriteLine( $"{record.Name}");
}

Console.WriteLine( $"{temporanea}");
 ###
- codice completo di svolgimento:
 ###
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
###
 
- allego il risultato che si ottiene:
 ###
 in questa tabella ci sono 275record
AC/DC
Accept
Aerosmith
Alanis Morissette
Alice In Chains
Antônio Carlos Jobim
Apocalyptica
Audioslave
BackBeat
Billy Cobham
Black Label Society
Black Sabbath
Body Count
Bruce Dickinson
Buddy Guy
Caetano Veloso
Chico Buarque
Chico Science & Nação Zumbi
Cidade Negra
Cláudio Zoli
Various Artists
Led Zeppelin
Frank Zappa & Captain Beefheart
Marcos Valle
Milton Nascimento & Bebeto
Azymuth
Gilberto Gil
João Gilberto
Bebel Gilberto
Jorge Vercilo
Baby Consuelo
Ney Matogrosso
Luiz Melodia
Nando Reis
Pedro Luís & A Parede
O Rappa
Ed Motta
Banda Black Rio
Fernanda Porto
Os Cariocas
Elis Regina
Milton Nascimento
A Cor Do Som
Kid Abelha
Sandra De Sá
Jorge Ben
Hermeto Pascoal
Barão Vermelho
Edson, DJ Marky & DJ Patife Featuring Fernanda Porto
Metallica
Queen
Kiss
Spyro Gyra
Green Day
David Coverdale
Gonzaguinha
Os Mutantes
Deep Purple
Santana
Santana Feat. Dave Matthews
Santana Feat. Everlast
Santana Feat. Rob Thomas
Santana Feat. Lauryn Hill & Cee-Lo
Santana Feat. The Project G&B
Santana Feat. Maná
Santana Feat. Eagle-Eye Cherry
Santana Feat. Eric Clapton
Miles Davis
Gene Krupa
Toquinho & Vinícius
Vinícius De Moraes & Baden Powell
Vinícius De Moraes
Vinícius E Qurteto Em Cy
Vinícius E Odette Lara
Vinicius, Toquinho & Quarteto Em Cy
Creedence Clearwater Revival
Cássia Eller
Def Leppard
Dennis Chambers
Djavan
Eric Clapton
Faith No More
Falamansa
Foo Fighters
Frank Sinatra
Funk Como Le Gusta
Godsmack
Guns N' Roses
Incognito
Iron Maiden
James Brown
Jamiroquai
JET
Jimi Hendrix
Joe Satriani
Jota Quest
João Suplicy
Judas Priest
Legião Urbana
Lenny Kravitz
Lulu Santos
Marillion
Marisa Monte
Marvin Gaye
Men At Work
Motörhead
Motörhead & Girlschool
Mônica Marianno
Mötley Crüe
Nirvana
O Terço
Olodum
Os Paralamas Do Sucesso
Ozzy Osbourne
Page & Plant
Passengers
Paul D'Ianno
Pearl Jam
Peter Tosh
Pink Floyd
Planet Hemp
R.E.M. Feat. Kate Pearson
R.E.M. Feat. KRS-One
R.E.M.
Raimundos
Raul Seixas
Red Hot Chili Peppers
Rush
Simply Red
Skank
Smashing Pumpkins
Soundgarden
Stevie Ray Vaughan & Double Trouble
Stone Temple Pilots
System Of A Down
Terry Bozzio, Tony Levin & Steve Stevens
The Black Crowes
The Clash
The Cult
The Doors
The Police
The Rolling Stones
The Tea Party
The Who
Tim Maia
Titãs
Battlestar Galactica
Heroes
Lost
U2
UB40
Van Halen
Velvet Revolver
Whitesnake
Zeca Pagodinho
The Office
Dread Zeppelin
Battlestar Galactica (Classic)
Aquaman
Christina Aguilera featuring BigElf
Aerosmith & Sierra Leone's Refugee Allstars
Los Lonely Boys
Corinne Bailey Rae
Dhani Harrison & Jakob Dylan
Jackson Browne
Avril Lavigne
Big & Rich
Youssou N'Dour
Black Eyed Peas
Jack Johnson
Ben Harper
Snow Patrol
Matisyahu
The Postal Service
Jaguares
The Flaming Lips
Jack's Mannequin & Mick Fleetwood
Regina Spektor
Scorpions
House Of Pain
Xis
Nega Gizza
Gustavo & Andres Veiga & Salazar
Rodox
Charlie Brown Jr.
Pedro Luís E A Parede
Los Hermanos
Mundo Livre S/A
Otto
Instituto
Nação Zumbi
DJ Dolores & Orchestra Santa Massa
Seu Jorge
Sabotage E Instituto
Stereo Maracana
Cake
Aisha Duo
Habib Koité and Bamada
Karsh Kale
The Posies
Luciana Souza/Romero Lubambo
Aaron Goldberg
Nicolaus Esterhazy Sinfonia
Temple of the Dog
Chris Cornell
Alberto Turco & Nova Schola Gregoriana
Richard Marlow & The Choir of Trinity College, Cambridge
English Concert & Trevor Pinnock
Anne-Sophie Mutter, Herbert Von Karajan & Wiener Philharmoniker
Hilary Hahn, Jeffrey Kahane, Los Angeles Chamber Orchestra & Margaret Batjer
Wilhelm Kempff
Yo-Yo Ma
Scholars Baroque Ensemble
Academy of St. Martin in the Fields & Sir Neville Marriner
Academy of St. Martin in the Fields Chamber Ensemble & Sir Neville Marriner
Berliner Philharmoniker, Claudio Abbado & Sabine Meyer
Royal Philharmonic Orchestra & Sir Thomas Beecham
Orchestre Révolutionnaire et Romantique & John Eliot Gardiner
Britten Sinfonia, Ivor Bolton & Lesley Garrett
Chicago Symphony Chorus, Chicago Symphony Orchestra & Sir Georg Solti
Sir Georg Solti & Wiener Philharmoniker
Academy of St. Martin in the Fields, John Birch, Sir Neville Marriner & Sylvia McNair
London Symphony Orchestra & Sir Charles Mackerras
Barry Wordsworth & BBC Concert Orchestra
Herbert Von Karajan, Mirella Freni & Wiener Philharmoniker
Eugene Ormandy
Luciano Pavarotti
Leonard Bernstein & New York Philharmonic
Boston Symphony Orchestra & Seiji Ozawa
Aaron Copland & London Symphony Orchestra
Ton Koopman
Sergei Prokofiev & Yuri Temirkanov
Chicago Symphony Orchestra & Fritz Reiner
Orchestra of The Age of Enlightenment
Emanuel Ax, Eugene Ormandy & Philadelphia Orchestra
James Levine
Berliner Philharmoniker & Hans Rosbaud
Maurizio Pollini
Academy of St. Martin in the Fields, Sir Neville Marriner & William Bennett
Gerald Moore
Mela Tenenbaum, Pro Musica Prague & Richard Kapp
Emerson String Quartet
C. Monteverdi, Nigel Rogers - Chiaroscuro; London Baroque; London Cornett & Sackbu
Nash Ensemble
Philip Glass Ensemble
275
 ###
 
 

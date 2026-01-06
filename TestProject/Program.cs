// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

/*
string firstName = "Bob" ;
int widgetsPurchased = 7 ;
Console.WriteLine($"{firstName} Purchased {widgetsPurchased} widgets.") ;
*/

using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;

/*
    The following code creates five random OrderIDs
    to test the fraud detection process. OrderIDs
    consist of a letter from A to E, and a three
    digit number. Ex. A123.
*/
/*
Random random = new Random() ;
string[] orderIDs = new string[5] ;

for( int i = 0 ; i < orderIDs.Length ; i++ )
{
    int prefixValue = random.Next( 65, 70 ) ;
    String prefix = Convert.ToChar( prefixValue ).ToString() ;
    string suffix = random.Next( 1, 1000 ).ToString("000") ;

    orderIDs[i] = prefix + suffix ;
}
// Print out each orderID
foreach( var orderID in orderIDs )
{
    Console.WriteLine( orderID ) ;
}
*/
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
*/

string str = "The quick brown fox jumps over the lazy dog." ;

char[] charMessage = str.ToCharArray() ;
Array.Reverse( charMessage ) ;
int x = 0 ;

foreach( char i in charMessage )
{
    if( i == 'o')
    {
        x++ ;
    }
}

string new_message = new String( charMessage ) ;

Console.WriteLine(new_message) ;
Console.WriteLine($"'o' appears {x} times.") ;
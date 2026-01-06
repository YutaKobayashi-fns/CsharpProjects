// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

/*
string[] fraudulentOrderIDs = new string[3] ;

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
*/
/*
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ] ;

Console.WriteLine($"First: {fraudulentOrderIDs[0]}") ;
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}") ;
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}") ;

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}") ;
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.") ;
*/

//============================================================
/*
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

string[] names = { "Rowena", "Robin", "Bao" } ;
foreach( String name in names)
{
    Console.WriteLine( name ) ;
}
*/

//============================================================
/*
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

int[] inventory = { 200, 450, 700, 175, 250 } ;
int sum = 0 ;

int bin = 0 ;

foreach( int items in inventory )
{
    sum += items ;
    bin++ ;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})") ;
}

Console.WriteLine($"We have {sum} items in inventory.") ;
*/

//============================================================

using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;

String[] orderID = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" } ;
int bin = 0 ;

foreach( string name in orderID )
{
    //IDにBを含むか？
    if( name.StartsWith('B'))
    {
        Console.WriteLine($"orderID[{bin}]: {name}") ;
    }
    bin++ ;
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");
/*
Console.WriteLine("a" == "a") ;
Console.WriteLine("a" == "A") ;
Console.WriteLine( 1 == 2 ) ;

string myValue = "a" ;
Console.WriteLine( myValue == "a" ) ;
*/

//string value1 = " a" ;
//string value2 = "A " ;
//Console.WriteLine( value1.Trim().ToLower() == value2.Trim().ToLower()) ;

/*
Console.WriteLine("a" != "a") ;
Console.WriteLine("a" != "A") ;
Console.WriteLine( 1 != 2 ) ;

string myvalue = "a" ;
Console.WriteLine( myvalue != "a") ;
*/

//Console.WriteLine( 1 > 2 ) ;
//Console.WriteLine( 1 < 2 ) ;
//Console.WriteLine( 1 >= 1 ) ;
//Console.WriteLine( 1 <= 1 ) ;

//string pangram = "The quick brown fox jumps over the lazy dog." ;
// These two lines of code will create the same output
//Console.WriteLine( pangram.Contains("fox") == false ) ;
//Console.WriteLine( !pangram.Contains("fox")) ;

//string pangram = "The quick brown fox jumps over the lazy dog." ;
//Console.WriteLine(!pangram.Contains("fox")) ;
//Console.WriteLine(!pangram.Contains("cow")) ;
/*
int a = 7 ;
int b = 6 ;
Console.WriteLine( a != b ) ;// output:a True
string s1 = "Hello" ;
string s2 = "Hello" ;
Console.WriteLine( s1.ToLower() != s2 ) ;// output: False
*/

//int saleAmount = 1000 ;
//int saleAmount = 1001 ;
// int discount = saleAmount > 1000 ? 100 : 50 ;
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}") ;

//演習3-1
/*
Random coin = new Random() ;
int result = coin.Next(1,3) ;
Console.WriteLine($"result{result}: {(result == 1 ? "heads" : "tails")}") ;
*/

//string permission = "Admin" ;
//string permission = "Manager" ;
string permission = "Guest" ;
int level = 99 ;
permission.Contains("Admin") ;

if( permission.Contains("Admin") == true )
{
    if( level > 55 )
    {
        Console.WriteLine("Welcome, Super Admin user.") ;
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.") ;
    }
}
else if( permission.Contains("Manager") == true )
{
    if( level >= 20 )
    {
        Console.WriteLine("Contact an Admin for access.") ;
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.") ;
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges!") ;
}
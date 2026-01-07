// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");
/*
for( int i = 0 ; i < 10 ; i++ )
{
    Console.WriteLine( i ) ;
    if( i== 7 ) break ;
}
*/

/*
string[] names = {"Alex", "Eddie", "David", "Michael"} ;

for( int i = 0 ; i < names.Length ; i++ )
{
    if( names[i] == "David" ) names[i] = "Sammy" ;
}

foreach( var name in names ) Console.WriteLine( name ) ;
*/

//演習
for( int i = 1 ; i <= 100 ; i++ )
{
    if(( i % 3 == 0 ) && ( i % 5 == 0))
    {
        Console.WriteLine($"{i} - FizzBuzz") ;
    }
    else if( i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz") ;
    }
    else if( i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz") ;
    }
    else
    {
        Console.WriteLine( i ) ;
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

/*
bool flag = true ;
int value = 0 ;

if( flag )
{
    Console.WriteLine($"Inside the code block: {value}") ;
}

value = 10 ;
Console.WriteLine($"Outside the code block: {value}") ;
*/

/*
bool flag = true ;
if( flag) Console.WriteLine( flag ) ;
*/

/*
string name = "steve" ;

if( name == "bob" )
    Console.WriteLine("Found Bob") ;
else if( name == "steve" )
    Console.WriteLine("Found Steve") ;
else
    Console.WriteLine("Found chuck") ;
*/

int[] numbers = { 4, 8, 15, 16, 23, 44 } ;
int total = 0 ;
bool found = false ;

foreach(int number in numbers)
{
    total += number;

    if( number == 42 )
       found = true ;
}

if( found ) 
    Console.WriteLine("Set contains 42") ;
else

    Console.WriteLine("Set not contains 42") ;

Console.WriteLine($"Total: {total}") ;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

using System.ComponentModel.DataAnnotations;

Random random = new Random() ;
int current = random.Next( 1, 11 ) ;
/*
do
{
    current = random.Next( 1, 11 ) ;

    if( current >= 8 ) continue ;

    Console.WriteLine( current ) ;
} while( current != 7 ) ;
*/
/*
while( current >= 3 )
{
    Console.WriteLine( current ) ;
    current = random.Next( 1, 11 ) ;
}
Console.WriteLine($"Last number: {current}") ;
*/

//演習01
/*
int heroHealthPoint = 10 ;
int monsterHealthPoint = 10 ;
int currentAttackPoint = 0 ;
Random currentAttackDamege = new Random() ;

while( heroHealthPoint > 0 )
{
    currentAttackPoint = currentAttackDamege.Next( 1, 11 ) ;
    monsterHealthPoint -= currentAttackPoint ;
    Console.WriteLine($"Monster was damaged and lost {currentAttackPoint} health and now has {monsterHealthPoint} health.") ;

    if( monsterHealthPoint <= 0 )
    {
        Console.WriteLine("Hero wins!") ;
        break ;
    }

    currentAttackPoint = currentAttackDamege.Next( 1, 11 ) ;
    heroHealthPoint -= currentAttackPoint ;
    Console.WriteLine($"Hero was damaged and lost {currentAttackPoint} health and now has {heroHealthPoint} health") ;

    if( heroHealthPoint <= 0 )
    {
        Console.WriteLine("Hero is Lose...") ;
        break ;
    }
}
*/

/*
string? readResult ;
Console.WriteLine("Enter a string:") ;
do
{
    readResult = Console.ReadLine() ;

    int numericValue = 0 ;
    bool validNumber = false ;

    validNumber = int.TryParse( readResult, out numericValue ) ;
    Console.WriteLine($"{readResult} {numericValue} {validNumber}") ;

} while( readResult == null ) ;
*/

//演習02-01
/*
string? readResult ;
string resultReadValue = "" ;
int numericValue = 0 ;
bool validNumber = false ;

Console.WriteLine("Please enter an integer value between 5 and 10.") ;

do
{
    readResult = Console.ReadLine() ;
    
    if( readResult != null )
    {
        resultReadValue = readResult ;
        validNumber = int.TryParse( resultReadValue, out numericValue ) ;
    }

    if(( validNumber == true ) && ( numericValue < 5 ) || ( numericValue > 10 ))
    {
        validNumber = false ;
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.") ;
    }
    else if( validNumber == false )
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again") ;
    }

} while( validNumber == false ) ;

Console.WriteLine($"Your input value ({numericValue}) has been accepted.") ;
readResult = Console.ReadLine();
*/

//演習02-02
/*
string? readResult ;
string resultReadValue = "" ;
bool entryResult = false ;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)") ;

do
{
    readResult = Console.ReadLine() ;

    if( readResult != null )
    {
        resultReadValue = readResult ;
        switch( resultReadValue.Trim().ToLower())
        { 
            case "administrator":
            case "manager":
            case "user":
                entryResult = true ;
                break ;
            default:
                Console.WriteLine($"The role name that you entered, \"{resultReadValue.Trim()}\" is not valid. Enter your role name (Administrator, Manager, or User)") ;
                break ;
        }
    }
} while( entryResult == false ) ;

Console.WriteLine($"Your input value ({resultReadValue.Trim()}) has been accepted.") ;
readResult = Console.ReadLine() ;

*/

//演習02-03

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" } ;
string resultString = "" ;
int periodLocation = 0 ;

foreach( var myString in myStrings)
{
    periodLocation = myString.IndexOf('.') ;
    resultString = myString ;

    if( periodLocation != -1 )
    {
        int stringEndIndex = 0 ;

        do
        {
            resultString = resultString.TrimStart() ;
            periodLocation = resultString.IndexOf('.') ;

            if( periodLocation != -1 )
            {
                stringEndIndex = periodLocation + 1 ;
                Console.WriteLine( $"{resultString.Substring( 0, stringEndIndex - 1 ).TrimStart('.')}" ) ;

            }
            else
            {
                stringEndIndex = resultString.Length ;
                Console.WriteLine( $"{resultString.Substring( 0, stringEndIndex ).TrimStart('.')}" ) ;
            }

            resultString = resultString.Remove( 0, stringEndIndex ) ;
   
        } while( resultString.Length > 0 ) ;
    }

    if( resultString.Length > 0)
    {
        Console.WriteLine( $"{resultString}" ) ;
    }
}

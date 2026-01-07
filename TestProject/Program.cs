// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

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

//演習

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
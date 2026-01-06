// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

/*
using System.Data;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Emit;

Random dice = new Random() ;

int roll1 = dice.Next( 1, 7 ) ;
int roll2 = dice.Next( 1, 7 ) ;
int roll3 = dice.Next( 1, 7 ) ;

roll1 = 3;
roll2 = 2;
roll3 = 1;

int total = roll1 + roll2 + roll3 ;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}") ;

if(( roll1 == roll2 ) || ( roll2 == roll3 ) || ( roll1 == roll3 ))
{
    if(( roll1 == roll2 ) && ( roll2 == roll3 ))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!") ;
        total += 6 ;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!") ;
        total += 2 ;
    }
}

if( total >= 16 )
{
    Console.WriteLine("You win a new car!") ;
} 
else if( total >= 10 )
{
    Console.WriteLine("You win a new laptop!") ;
}
else if( total == 7 )
{
    Console.WriteLine("You win a trip for two!") ;
}
else
{
    Console.WriteLine("You win a kitten!") ;
}
*/
//============================================================
using System.Linq.Expressions;
using System.Security.Cryptography;

Random random = new Random() ;
int dayUntilExpiration = random.Next( 12 ) ;
int discountPercentage = 0 ;

//有効期限まで10日以下か？
if( dayUntilExpiration <= 10 )
{
    //有効期限内か？
    if ( dayUntilExpiration > 0 )
    {
        //有効期限は1日以内か？
        if( dayUntilExpiration == 1 )
        {
            discountPercentage = 20 ;
            Console.WriteLine("Your subscription expires within a day!") ;
            Console.WriteLine($"Renew now and save {discountPercentage}%!") ;
        }
        //有効期限は5日以内か？
        else if( dayUntilExpiration <= 5 )
        {
            discountPercentage = 10 ;
            Console.WriteLine($"Your subscription expires in {dayUntilExpiration} days.") ;
            Console.WriteLine($"Renew now and save {discountPercentage}%!") ;
        }
        //有効期限10日以内
        else
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!") ;
        }
    }
    //有効期限切れ
    else
    {
        Console.WriteLine("Your subscription has expired.") ;
    }
}


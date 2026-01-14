// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

/*
string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
*/

/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if(openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the substring to return only the remaining
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
*/

/*
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
*/

/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of charavters.
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through
// the characters in the string. This time, use the closing
// position of the previous iteration as the starting index for the
// next open symbol. So, you need to initialize the closingPosition
// variable to zero:
*/

/*
int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    //Now find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;            
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify
    // that the search for the matchingSymbol should start at the openingPosition in the string.

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

/*
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
*/

/*
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-","");
Console.WriteLine(message);
*/

const string input = "<div><h2>widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";
const string openDive = "<div>";
const string closeDive = "</div>";
const string trade = "&trade;";

int openingSpanPosition = 0;
int closingSpanPosition = 0;
int openingDivPosition = 0;
int closingDivPosition = 0;
int length = 0;

// quantity data
openingSpanPosition = input.IndexOf(openSpan) + 6;
closingSpanPosition = input.IndexOf(closeSpan);

length = closingSpanPosition - openingSpanPosition;
quantity += input.Substring(openingSpanPosition, length);
quantity = $"Quantity: {quantity}";

// output data
openingDivPosition = input.IndexOf(openDive);
output = input.Remove(openingDivPosition, openDive.Length);

closingDivPosition = output.IndexOf(closeDive);
output = output.Remove(closingDivPosition, closeDive.Length);

output = output.Replace(trade, "&reg;");

output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);

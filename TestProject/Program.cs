// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello C#!");

/*
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Cleaning 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

/*
string pangram = "The quick brown fox jumps over the lazy dog";
string pangramReverse = "";
string[] results = pangram.Split(' ');

for (int i = 0; i < results.Length; i++)
{
    char[] word = results[i].ToCharArray();
    Array.Reverse(word);
    string reverseWord = new string(word);
    results[i] = reverseWord ;
}

pangramReverse = string.Join(" ", results);

Console.WriteLine($"{pangramReverse}");
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(',');

Array.Sort(orderIDs);

foreach( var orderID in orderIDs)
{
    if(orderID.Length == 4)
    {
        Console.WriteLine($"{orderID}");
    }
    else
    {
        Console.WriteLine($"{orderID}\t- Error");
    }
}

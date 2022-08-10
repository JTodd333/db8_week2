//Let's do a dictionary like this:
//  1  "One"
//  10  "Ten"
//  20  "Twenty"
//  100  "One Hundred"

//Key is int
// Value is string

Dictionary<int, string> numToWord = new Dictionary<int, string>();

numToWord[1] = "One";
numToWord[10] = "Ten";
numToWord[20] = "Twenty";
numToWord[100] = "One Hundred";


//Print out all the keys

Console.WriteLine("Here are the keys:");
foreach(int key in numToWord.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine();
Console.WriteLine("Here are the values:");
foreach (string value in numToWord.Values)
{
    Console.WriteLine(value);
}
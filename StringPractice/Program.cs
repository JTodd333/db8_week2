//https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0

string sentence = "Hello there everybody from planet Earth!";

string[] words = sentence.Split(); //noun dot verb, the noun is a variable, in this case sentence (string).

foreach(string word in words)
{
    Console.WriteLine(word);
}
Console.WriteLine();
Console.WriteLine("Split by commas:");
sentence = "Hello,there,everybody,from,planet,Earth!";

char[] delims = { ',', ' ' }; //Split by comma or space
words = sentence.Split(delims); //',' instead of delims would only split by ,
foreach (string word in words)
{
    Console.WriteLine(word);
}

//Let's join these words back together

sentence = string.Join(';', words);
Console.WriteLine(sentence);

//Now lets try joining with spaces

sentence = string.Join(' ', words); // noun dot verb, the noun is a type, in this case string. (similar to int.Parse)
                                    // Methods that are attached to the type itself are called "static" methods.
                                    // Methods that are attached to an instance of the type (such as sentence) are called
                                    //  instance methods.
Console.WriteLine(sentence);

//Let's find the position of a letter in a string.
//IndexOf uses a common approad: It returns a 0-based index, or -1 if it doesnt find it.
Console.WriteLine();
Console.WriteLine("IndexOf Practice:");
sentence = "We will find a letter position.";
Console.WriteLine(sentence.IndexOf('i'));    //prints 4, 1st instance
Console.WriteLine(sentence.IndexOf('x'));    //prints -1, doesnt exist.
Console.WriteLine(sentence.LastIndexOf('i'));
Console.WriteLine(sentence.LastIndexOf('x'));

//Let's use Substring to find a piece of a string
Console.WriteLine();
Console.WriteLine("Substing practice");
sentence = "Hello World";
Console.WriteLine(sentence.Substring(1));   //Expect "ello World"
Console.WriteLine(sentence.Substring(3));   //Expect "lo World"
Console.WriteLine(sentence.Substring(4,3)); //Expect "o W"

Console.WriteLine();
Console.WriteLine("Building a string");

string letters = "Hello";
letters = letters + "a";
letters = letters + "b";
letters = letters + "c";
Console.WriteLine(letters);     //Bad practice

// The documentation will say not to do what I just did.
//  But this is fine for small strings like we have here.
// This is not an entire 1000 page novel that will take up a lot of memory.
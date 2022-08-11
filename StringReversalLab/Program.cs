//Reversing a word/full sentence in backwards order:
Console.WriteLine("Welcome! Please enter a word:");
string entry = Console.ReadLine();
ReverseWord(entry);

Console.WriteLine();

//Reversing Sentences while maintaining order: (Extra Challenge)
Console.WriteLine("Enter a sentence to reverse:");
string sentence = Console.ReadLine();
ReverseSentence(sentence);

Console.WriteLine();

Console.WriteLine("Thank you!");


//Reversing word/full sentence method
static void ReverseWord(string word)
{
    Stack<char> chars = new Stack<char>();

    for (int i = 0; i < (word.Length); i++)
    {
        chars.Push(word[i]);
    }
    while (chars.Count > 0)
    {
        char c = chars.Pop();
        Console.Write(c);
    }
}

//Reversing full sentence while maintaining order method.
static void ReverseSentence(string sentence)
{
    Stack<char> wordstack = new Stack<char>();

    for (int i = 0; i < sentence.Length; i++)
    {
        if (sentence[i] != ' ')
        {
            wordstack.Push(sentence[i]);
        }
        else
        {
            while (wordstack.Count > 0)
            {
                Console.Write(wordstack.Pop());
            }
            Console.Write(" ");
        }
    }
    //This portion completes the last word
    while (wordstack.Count > 0)
    {
        Console.Write(wordstack.Pop());
    }
}

//This code is my past code before it was in Methods.
//Console.WriteLine("Welcome! Please enter a word:");

//string entry;
//entry = Console.ReadLine();

////static void ReverseMeth()
////{ 
//Stack<char> chars = new Stack<char>();

//for (int i = 0; i < (entry.Length); i++)
//{
//    chars.Push(entry[i]);
//}
//while (chars.Count > 0)
//{
//    char c = chars.Pop();
//    Console.Write(c);
//}
////}
//Console.WriteLine();

////Reversing Sentences
//Console.WriteLine("Enter a sentence to reverse:");
//string sentence = Console.ReadLine();
//Stack<char> wordstack = new Stack<char>();

//for (int i = 0; i < sentence.Length; i++)
//{
//    if (sentence[i] != ' ')
//    {
//        wordstack.Push(sentence[i]);
//    }
//    else
//    {
//        while (wordstack.Count > 0)
//        {
//            Console.Write(wordstack.Pop());
//        }
//        Console.Write(" ");
//    }
//}
//while (wordstack.Count > 0)
//{
//    Console.Write(wordstack.Pop());
//}
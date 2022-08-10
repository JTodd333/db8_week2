//Let's make an array for comparison
string[] myarray = { "abd", "def", "ghi"};

//Let's print out one element
Console.WriteLine(myarray[0]);

//Let's change one of the members
myarray[1] = "jkl";

//Let's loop through it
for (int ind = 0; ind < myarray.Length; ind++)
{
    Console.WriteLine(myarray[ind]);
}

Console.WriteLine();

//
//Now let's use a List
//

List<string> mylist = new List<string>();
mylist.Add("abc");
mylist.Add("def");
mylist.Add("ghi");

//Let's print out one element.
Console.WriteLine(mylist[0]);

//Let's change one of the elements.
mylist[1] = "jkl";

//Let's add another one!
mylist.Add("mno");
//With the for loop, we have the index and from there can grab the element
for(int ind = 0; ind < mylist.Count; ind++)
{
    Console.WriteLine(mylist[ind]);
}

//Delete one from the list
//Insert one into the list
//We'll look at the official documentation

Console.WriteLine("Let's remove the one at index 2");
mylist.RemoveAt(2);
for (int ind = 0; ind < mylist.Count; ind++)
{
    Console.WriteLine(mylist[ind]);
}

Console.WriteLine("Let's remove one by name: abc");
mylist.Remove("abc");  //Removes only the frist one it finds
for (int ind = 0; ind < mylist.Count; ind++)
{
    Console.WriteLine(mylist[ind]);
}

// xxx here yyy

Console.WriteLine("Now let's insert one in between the first two.");
mylist.Insert(1, "pqr"); //Can't do this with an array!
//for (int ind = 0; ind < mylist.Count; ind++)
//{
//    Console.WriteLine(mylist[ind]);
//}
foreach (string word in mylist) // you can declare it any name, doesnt have to be "word"
{
    //We can't see the index we are on (will go through all index)
    Console.WriteLine(word);
}

//Some functions modify the list. They actually do change the list itself, unlike string functions.
Console.WriteLine("Let's sort the list.");
mylist.Sort();
foreach (string word in mylist) 
{
    Console.WriteLine(word);
}

//Let's check if one exists
Console.WriteLine("Type in a words and we'll see if it's in the list.");
string entry = Console.ReadLine();
int index = mylist.IndexOf(entry);      //gives back -1 if it doesnt find it in list by default
if (index >= 0)                         //Above locates where one is in the list
{
    Console.WriteLine($"Found {entry} at {index}.");
}
else
{
    Console.WriteLine($"Sorry, {entry} is not in the list.");
}


//Let's initialize a list
Console.WriteLine("Let's initialize a list of integers");
List<int> numbers = new List<int>() { 5, 3, 8, 2 }; //In practice, this doesnt happen much. From database instead.
foreach(int nextnum in numbers)
{
    Console.WriteLine($"The next number is {nextnum}");
}


//Let's start with a list for comparison

List<string> letters = new List<string>();
letters.Add("abc");
letters.Add("def");
letters.Add("ghi");
letters.Add("jkl");
letters.Add("mno");

Console.WriteLine("Here are the letters");
foreach (string next in letters)
{
    Console.WriteLine(next);    
}

Dictionary<string, string> foods = new Dictionary<string, string>();//<key we are looking up by, value returning>
foods["Paul"] = "Spaghetti";
foods["Sarah"] = "Pizza";
foods["Quincy"] = "Tacos";
foods["Ruby"] = "Ice Cream";
foods["Terry"] = "Tacos";

//Let's print out Ruby's favorite food.
Console.WriteLine("Here is Ruby's favorite food:");
Console.WriteLine(foods["Ruby"]);

//Paul changed his mind. He likes Hamburgers.
foods["Paul"] = "Hamburgers";
Console.WriteLine($"Paul now likes {foods["Paul"]}");

//Do not assume a fixed order. If you need ordering, use a list.
foreach (var pair in foods) //doesnt have to be "pair". (Type is a bit more complicated, so just used var)
{
    Console.WriteLine("The name and the food are:");
    Console.WriteLine(pair.Key);    //the persons's name
    Console.WriteLine(pair.Value);  //their favorite food
}

//Do not rely on getting results back in specific order with dictionary. They can be returned in any order technically.


//Check if an item exists in the dictionary

//Console.WriteLine(foods["ABC"]); // if we did this first and it was not in there program would end before reaching next code.
//This is why we want to always check if it contains first.

string entry = Console.ReadLine();
if (foods.ContainsKey(entry)) //This gives us back true if in there, if not returns false
{
    Console.WriteLine($"Yes, we have a favroite food for {entry}.");
    Console.WriteLine(foods[entry]);
}
else
{
    Console.WriteLine("We dont know that person.");
}
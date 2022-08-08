//An array is a variable that can hold a list of things

int[] grades = {100, 80, 100, 60, 85};

Console.WriteLine(grades[0]); //prints the 1st grade in list, index 0
Console.WriteLine(grades[1]); //Expect 80
Console.WriteLine(grades[4]); //Expect 85


string[] names = { "Fred", "Jamal", "Yasmine", "Ziggy" };
Console.WriteLine(names[0]);
Console.WriteLine(names[2]);

Console.WriteLine();
int index = 3;
Console.WriteLine(names[index]); //Same as names[3], expect to see Ziggy

Console.WriteLine();
for (int ind = 0; ind < 4; ind++) //loop from index 0-3 the names
{
    Console.WriteLine(names[ind]);
}

Console.WriteLine();
//Same thing, but let use <=3 instead. Jeff usually does this way
for (int ind = 0; ind <=3; ind++)
{
    Console.WriteLine(names[ind]);
}

//Let's change one. Suppose we misspelled the third name. Should be Jasmine.
//We're actually changing the entire string, replacing it. Strings are immutable. We can't change individual letter.
names[2] = "Jasmine";
Console.WriteLine();
Console.WriteLine($"We corrected the spelling of {names[2]}");

//let's change the first grade
grades[0] = 99;
Console.WriteLine($"The first grade is now {grades[0]}");

//with arrays you cannot add addtional items after unless you go back to the lines it's on/
//example: couldnt do names[4] = "Hank" here and add it on.
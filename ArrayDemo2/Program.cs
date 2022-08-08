string[] names = { "Abdul Amin", "Barbara Baker", "Cherine Cooper", "Douglas Dickerson", "Emily Emerson" };
int[] grades = { 95, 98, 85, 80, 70 };

//Print out all the grades

for (int index = 0; index <= 4; index++) //1st piece sets up variable, 2nd how long it goes for, 3rd how often
{
    Console.WriteLine($"{names[index]} has grade {grades[index]}");
}

//Print out all the grades but slightly different for loop
//Ask the first array how long it is. It will tell us it has 5 members (or elements).
//but the bounds are 0 to 4.
//that upper bound, 4, is one less than the size of the array.
Console.WriteLine();
Console.WriteLine($"There are {names.Length} students."); 
for (int index = 0; index <names.Length; index++) //Instead of index <= names.Length -1
{
    Console.WriteLine($"{names[index]} has grade {grades[index]}.");
}

//Ask the user which one to print out  //(commented out for example purpose, using next instead)
//Console.WriteLine();
//Console.WriteLine("Please enter a number.");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);

//Console.WriteLine($"{names[num]} has grade {grades[num]}");

//Ask the user which one to print out, but start with 1. (More user friendly)
//So if they type "1" we want to give them back index 0. So we need to subtract 1.
// Version 1
//Console.WriteLine();
//Console.WriteLine("Please enter a number from 1 to 5.");
//string entry = Console.ReadLine();
//int num = int.Parse(entry);
//num--; //Convert the numer to an index.
//Console.WriteLine($"{names[num]} has grade {grades[num]}");

//Version 2

bool okay = false;
int num = 0;
while (okay == false) //this is a true statement so it will run as long as this remains true. Same as (!okay)
{
    Console.WriteLine();
    Console.WriteLine("Please enter a number from 1 to 5.");
    string entry = Console.ReadLine();
    bool validNumber = int.TryParse(entry, out num);

    if (validNumber)     //if (validNumber && (num >= 1 && num <= 5) )  is the same as below but not as readable.
                         //if (validNumber && num >= 1 && num <= 5) is also same but not very readable
    {
       if( num >= 1 && num <= 5)
        {
            num--;
            okay = true;
        }

    }
    //Although this is valid, please keep your code as simple as possible. Simple code less error.
    //if(validNumber && num <= 5 && num >= 1)
    //{
    //  okay=true;
    //}
    //
    //if (validNumber && (num >= 1 && num <= 5))    is a little better.
}
//This next code will run after they have entered a valid number.
Console.WriteLine($"{names[num]} has grade {grades[num]}");



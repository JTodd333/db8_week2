while (true)
{

    Console.WriteLine("Please enter an interger:");
    string entry = Console.ReadLine();

    int num;

    bool result = int.TryParse(entry, out num); //entry is passed in and num is what will come out
    //Console.WriteLine(result); //will be false if you dont enter a int and char instead.
    //Console.WriteLine(num); //TryParse Diagram example in notes (commented out this as prev example b4 if/else)

    if (result) // same as (result == true)
    {
        Console.WriteLine($"Great! Your number is {num}");
    }
    else
    {
        Console.WriteLine($"Sorry, {entry} is not an integer.");
    }
    
}

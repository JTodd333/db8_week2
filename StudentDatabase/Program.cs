string[] names = { "A", "B", "C", "D", "E" };
string[] hometown = { "Port Huron, MI", "Gatlinburg, TN", "Venice, FL", "Rapid City, SD", "Tokyo, Japan" };
string[] faveFood = { "Pizza", "BBQ", "Fish Tacos", "Buffalo Burger", "Sushi" };

do
{
    bool confirm = false;
    int num = 0;

    while (confirm == false)
    {
        Console.WriteLine("Hello! Which student would you like to learn more about?");
        Console.WriteLine("Enter a number 1-5:");
        string entry = Console.ReadLine();
        bool validNum = int.TryParse(entry, out num);

        if (validNum && (num >= 1 && num <= names.Length))
        {
          num--;
          confirm = true;
        }
        else
        {
            Console.WriteLine($"Sorry! That is not a number between 1 & {names.Length}. Please enter a number between 1 and {names.Length}.");
            confirm = false;
        }
    }

    Console.WriteLine($"Student {num + 1} is {names[num]}.");

    bool confirm2 = false;
    while (confirm2 == false)
    {
        Console.WriteLine("What would you like to know? Enter 'hometown' or 'favorite food':");
        string entry2 = Console.ReadLine().ToLower();
        if (entry2 == "hometown")
        {
            confirm2 = true;
            Console.WriteLine($"{names[num]} is from {hometown[num]}.");

        }
        else if (entry2 == "favorite food")
        {
            confirm2 = true;
            Console.WriteLine($"{names[num]}'s favorite food is {faveFood[num]}.");
        }
        else
        {
            Console.WriteLine("That category does not exist. Please try again. Enter 'hometown or 'favorite food'.");
            confirm2 = false;
        }
    }
} while (KeepGoing());



static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}
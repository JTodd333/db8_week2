
Console.WriteLine("Welcome to Poppy Market!");
Console.WriteLine();
//This is my customer's cart (List)
List<string> cart = new List<string>();

//Customer's Total
List<decimal> total = new List<decimal>();



//This is our store inventory


Dictionary<string, decimal> inventory = new Dictionary<string, decimal>();
    inventory["Apple"] = 1.00m;
    inventory["Banana"] = 0.40m;
    inventory["Grapes"] = 4.00m;
    inventory["Pear"] = 1.25m;
    inventory["Watermelon"] = 4.75m;
    inventory["Orange"] = 1.50m;
    inventory["Kiwi"] = 0.75m;
    inventory["Strawberries"] = 3.00m;

    Console.WriteLine("Item \t\t Price");
    Console.WriteLine("============================");
    foreach (var pair in inventory)
    {
        Console.WriteLine($"{pair.Key}\t\t ${pair.Value}");
    }
    Console.WriteLine();

do 
{
 
    bool valid = false;
    while (!valid)
    {
        Console.Write("Enter what would you like to add to your cart: ");
        string entry = Console.ReadLine();

        if (inventory.ContainsKey(entry))
        {
            valid = true;
            Console.WriteLine($"Added: {entry} ${(inventory[entry])}");
            cart.Add(entry);
            total.Add(inventory[entry]);
            Console.WriteLine("Your cart currently contains:");
            foreach (string items in cart)
            {
                Console.WriteLine(items);
            }
            //Console.WriteLine($"Total: {totalcart}");

        }
        else
        {
            Console.WriteLine("Sorry, we dont have that in stock.");
            valid = false;
        }
    } 
} while (AddItem());

//Final cart items and total after no longer continuing
Console.WriteLine("Thank you! Your Cart Contains:");
foreach (string items in cart)
{
    Console.WriteLine(items);
}

foreach (decimal price in total)
{
    Console.WriteLine($"${price}");
}

decimal totalcart = total.Sum();
Console.WriteLine("Your Total is: ");
Console.WriteLine($"${totalcart}");



//Asking to add another item to cart
static bool AddItem()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine();
        Console.WriteLine("Would you like add another item? (y/n)");
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
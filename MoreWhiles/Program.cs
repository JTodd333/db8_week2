int x = 0;

//while (10 > 9)
//{
//    Console.WriteLine($"While loop. x is{x}");    
//    x++;                          // This will run forever
//}

//while (9 > 10)
//{
//    //9 > 10 is a false statment, so this code will never run.
//    Console.WriteLine($"While loop. x is{x}");
//    x++;
//}

bool done = false;
while (!done)
{
    Console.WriteLine($"While loop. x is{x}");
    x++;
    //This will run forever

    if (x == 1000)
    {
        done = true;     //Will now run until it says 999
    }
}

Console.WriteLine($"All done for the day! x is now {x}");
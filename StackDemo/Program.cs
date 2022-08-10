//
// This examples demonstates two data structures: Stacks and Queues
// (Different "stack" than Stacks Vs Heaps concept
Console.WriteLine("Let's do some stack practice");
Stack<string> cards = new Stack<string>();

cards.Push("3D");     //This is Adding
cards.Push("AS");
cards.Push("QH");
cards.Push("10D");

string next = cards.Pop();     //This is Removing
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count);

//next= cards.Pop();   If we pop again, we'll get a "stack empty" exception.


Console.WriteLine();
Console.WriteLine("Now let's do some Queue practice.");

Queue<int> nums = new Queue<int>();
nums.Enqueue(5);   //5 got there first
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);

//Console.WriteLine(nums.Dequeue());   This line will throw an exception.

Console.WriteLine();
Console.WriteLine("Advanced stack stuck");

cards.Clear();   //empties out the stack. It clears it.

cards.Push("5D");
cards.Push("JH");
cards.Push("3S");  //So far we have 5D on the bottom, JH next on top, and 3S at the very top

Console.WriteLine(cards.Pop());  //Expect 3S

//Let's just took at the top of the deck but not pull it off.
string top = cards.Peek();
Console.WriteLine($"The top is {top} but we didn't remove it.");

//We didnt remove JH, so it's still there. So the next pop will be JH.

Console.WriteLine(cards.Pop());   //Expect JH

cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop());  //Expect KS

cards.Push("5D");

//Now let's draw them all off
Console.WriteLine("Let's draw all the rest of the cards!");
while (cards.Count > 0)
{
    next = cards.Pop();
    Console.WriteLine($"We just drew {next}.");
}

Console.WriteLine($"The count of the deck is now {cards.Count}");  //Expect to see 0


//One more stack demonstration.
Console.WriteLine();
Console.WriteLine("Lets put 5 cards on, and then draw them all off.");
cards.Clear();
cards.Push("AD");
cards.Push("2D");
cards.Push("3D");
cards.Push("4D");
cards.Push("5D");

while (cards.Count > 0)
{
    Console.WriteLine(cards.Pop());
}

//They came out in reverse

//One more queue demonstration.
Console.WriteLine();
Console.WriteLine("Let's put 5 numbers in a queue, then go through the whole queue.");
nums.Clear();     //Empty out the nums queue
nums.Enqueue(1);
nums.Enqueue(2);
nums.Enqueue(3);
nums.Enqueue(4);
nums.Enqueue(5);

while(nums.Count > 0)
{
    Console.WriteLine(nums.Dequeue());
}
//Prints out the same order as it was put in.
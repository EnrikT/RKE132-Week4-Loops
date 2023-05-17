
Random rnd = new Random();

int cpuRandom;

bool loopActive = true; //bool -true/false

while(loopActive)
{
    cpuRandom= rnd.Next(1 , 4);
    //Console.WriteLine($"cpu hase come up with:{cpuRandom}.");
    Console.WriteLine("Guess a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("You Won");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Try again");
    }
}
Console.WriteLine("Have a nice day!");
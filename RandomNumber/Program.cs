Random rnd= new Random();

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 5; i++) 
{
    myRandomNum = rnd.Next(0, 11); //0-10, viimane vaartus 1 vorra suurem
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"myRandomNum={myRandomNum}");
}
Console.WriteLine($"Random sum total: {randomSum}");
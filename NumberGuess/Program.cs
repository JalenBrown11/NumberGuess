// See https://aka.ms/new-console-template for more information
Random r = new Random();

int winnum = r.Next(0, 100);

bool win = false;

do
{
    Console.Write("Guess a number in-between 0 and 100: ");
    int num = int.Parse(Console.ReadLine());

    if (num > winnum) { Console.WriteLine("Guess to high..."); ; }
    else if (num < winnum) { Console.WriteLine("Guess to low..."); ; }
    else
    {
        Console.WriteLine("Correct guess, you win!");
        win = true;
    }

} while (win == false);

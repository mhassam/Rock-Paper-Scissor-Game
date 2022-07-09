using System;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random bet = new Random();
            String PlayerA = "Stone";
            String PlayerB = "";
            for (int i = 0; i < 100; i++)
            {
                switch (bet.Next(1, 100))
                {
                    case 1:
                        PlayerB = "Stone";
                        break;
                    case 2:
                        PlayerB = "Paper";
                        break;
                    case 3:
                        PlayerB = "Scissors";
                        break;
                }
                Console.WriteLine("Player A: " + PlayerA);
                Console.WriteLine("Player B: " + PlayerB);
                if (PlayerB == "Stone")
                {
                    Console.WriteLine("Match Draw");
                }
                else if (PlayerB == "Paper")
                {
                    Console.WriteLine("You LOSE!");
                }
                else
                {
                    Console.WriteLine("You WIN! CONGRATULATIONS!!");
                }
            }
        }
    }
}

using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Double odds = .75;
            Player player = new Player() { cash = 100, name = "The player" };



            Console.WriteLine("Welcome to the casino. The odds are " + odds);

            while (player.cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();

                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win " + winnings);
                            player.ReceiveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }

                Console.WriteLine("The house always wins!");


            }
        }
    }

}

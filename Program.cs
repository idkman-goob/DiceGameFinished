﻿namespace DiceGameFinished
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dealer and player now take turns on who decides first
            //added devmode, fixed the system for determining who wins
            int playersum = 0;
            int GameOngoing = 0;
            int turn = 0;
            int dealersum = 0;
            while (GameOngoing == 0)
            {
                if (turn == 0)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Your turn!");
                    Console.WriteLine("");
                    Console.WriteLine("You have " + playersum);
                    Console.WriteLine("Dealer has " + dealersum);
                    Console.WriteLine("");
                    Console.WriteLine("Roll or stay?");
                    string answer = Console.ReadLine();
                    if (answer == "roll")
                    {
                        turn = 1;
                        Random rand = new Random();
                        int playerthrow = rand.Next(1, 7);
                        playersum += playerthrow;
                        Console.WriteLine("You rolled " + playerthrow);
                        Console.WriteLine("You have " + playersum);
                        if (dealersum < 17 && dealersum < 21)
                        {

                            Random deal = new Random();
                            int dealerthrow = deal.Next(1, 7);
                            dealersum += dealerthrow;
                            Console.WriteLine("Dealer rolled " + dealerthrow);
                            Console.WriteLine("Dealer has " + dealersum);
                        }
                        else if (dealersum >= 17)
                        {
                            Random sigma = new Random();
                            int sigmaguy = sigma.Next(1, 3);
                            if (sigmaguy == 1)
                            {
                                Random deal = new Random();
                                int dealerthrow = deal.Next(1, 7);
                                dealersum += dealerthrow;
                                Console.WriteLine("Dealer rolled " + dealerthrow);
                                Console.WriteLine("Dealer has " + dealersum);
                            }
                            else if (sigmaguy == 2)
                            {
                                Console.WriteLine("Dealer stayed");
                                Console.WriteLine("Dealer has " + dealersum);
                            }
                        }
                    }
                    else if (answer == "stay")
                    {
                        turn = 1;
                        Console.WriteLine("You stayed");
                        Console.WriteLine("You have " + playersum);
                        if (dealersum <= 20)
                        {




                            if (dealersum < 17 && dealersum < 21)
                            {

                                Random deal = new Random();
                                int dealerthrow = deal.Next(1, 7);
                                dealersum += dealerthrow;
                                Console.WriteLine("Dealer rolled " + dealerthrow);
                                Console.WriteLine("Dealer has " + dealersum);
                            }
                            else if (dealersum >= 17)
                            {
                                Random sigma = new Random();
                                int sigmaguy = sigma.Next(1, 3);
                                if (sigmaguy == 1)
                                {
                                    Random deal = new Random();
                                    int dealerthrow = deal.Next(1, 7);
                                    dealersum += dealerthrow;
                                    Console.WriteLine("Dealer rolled " + dealerthrow);
                                    Console.WriteLine("Dealer has " + dealersum);
                                }
                                else if (sigmaguy == 2)
                                {
                                    Console.WriteLine("Dealer stayed");
                                    Console.WriteLine("Dealer has " + dealersum);
                                    GameOngoing = 1;
                                }
                            }
                        }
                        else
                        {
                            GameOngoing = 1;
                        }
                    }
                    else if (answer == "devmode")
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("");
                        Console.WriteLine("End game = 1");
                        Console.WriteLine("");
                        Console.WriteLine("Set dealersum to 21 = 2");
                        Console.WriteLine("");
                        Console.WriteLine("Set playersum to 21 = 3");
                        Console.WriteLine("");
                        Console.WriteLine("Make player win = 4");
                        Console.WriteLine("");
                        Console.WriteLine("Make dealer win = 5");
                        Console.WriteLine("");
                        Console.WriteLine("Make both lose = 6");
                        Console.WriteLine("");
                        int answer2 = int.Parse(Console.ReadLine());
                        if (answer2 == 1)
                        {
                            GameOngoing = 1;
                            Console.WriteLine("[Ended game]");
                        }
                        else if (answer2 == 2)
                        {
                            dealersum = 21;
                            Console.WriteLine("[Set dealersum to 21]");
                        }
                        else if (answer2 == 3)
                        {
                            playersum = 21;
                            Console.WriteLine("[Set playersum to 21]");
                        }
                        else if (answer2 == 4)
                        {
                            playersum = 21;
                            dealersum = 0;
                            GameOngoing = 1;
                            Console.WriteLine("[Set playersum to 21]");
                            Console.WriteLine("[Set dealersum to 0]");
                            Console.WriteLine("[Ended game]");
                        }
                        else if (answer2 == 5)
                        {
                            dealersum = 21;
                            playersum = 0;
                            GameOngoing = 1;
                            Console.WriteLine("[Set dealersum to 21]");
                            Console.WriteLine("[Set playersum to 0]");
                            Console.WriteLine("[Ended game]");
                        }
                        else if (answer2 == 6)
                        {
                            dealersum = 22;
                            playersum = 22;
                            GameOngoing = 1;
                            Console.WriteLine("[Set dealersum to 22]");
                            Console.WriteLine("[Set playersum to 22]");
                            Console.WriteLine("[Ended game]");
                        }
                    }
                }
                else if (turn == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Dealers turn!");
                    Console.WriteLine("");
                    Console.WriteLine("You have " + playersum);
                    Console.WriteLine("Dealer has " + dealersum);
                    Console.WriteLine("");
                    turn = 0;
                    if (dealersum <= 20)
                    {




                        if (dealersum < 17 && dealersum < 21)
                        {


                            Random sigma = new Random();
                            int sigmaguy = sigma.Next(1, 3);
                            if (sigmaguy == 1)
                            {
                                Random deal = new Random();
                                int dealerthrow = deal.Next(1, 7);
                                dealersum += dealerthrow;
                                Console.WriteLine("Dealer rolled " + dealerthrow);
                                Console.WriteLine("Dealer has " + dealersum);
                                Console.WriteLine("Would you like to roll or stay?");
                                string rollanswer = Console.ReadLine();
                                if (rollanswer == "stay")
                                {
                                    Console.WriteLine("You stayed");
                                    Console.WriteLine("You have " + playersum);

                                }
                                else if (rollanswer == "roll")
                                {
                                    Random rand = new Random();
                                    int playerthrow = rand.Next(1, 7);
                                    playersum += playerthrow;
                                    Console.WriteLine("You rolled " + playerthrow);
                                    Console.WriteLine("You have " + playersum);
                                }

                            }
                            else if (sigmaguy == 2)
                            {
                                Console.WriteLine("Dealer stayed");
                                Console.WriteLine("Dealer has " + dealersum);
                                Console.WriteLine("Would you like to roll or stay?");
                                string rollanswer = Console.ReadLine();
                                if (rollanswer == "stay")
                                {
                                    Console.WriteLine("You stayed");
                                    Console.WriteLine("You have " + playersum);
                                    GameOngoing = 1;
                                }
                                else if (rollanswer == "roll")
                                {
                                    Random rand = new Random();
                                    int playerthrow = rand.Next(1, 7);
                                    playersum += playerthrow;
                                    Console.WriteLine("You rolled " + playerthrow);
                                    Console.WriteLine("You have " + playersum);
                                }
                            }
                        }
                        else if (dealersum >= 17)
                        {
                            Random wow = new Random();
                            int wowguy = wow.Next(1, 3);
                            if (wowguy == 1)
                            {
                                Random deal = new Random();
                                int dealerthrow = deal.Next(1, 7);
                                dealersum += dealerthrow;
                                Console.WriteLine("Dealer rolled " + dealerthrow);
                                Console.WriteLine("Dealer has " + dealersum);
                                Console.WriteLine("Would you like to roll or stay?");
                                string rollanswer = Console.ReadLine();
                                if (rollanswer == "stay")
                                {
                                    Console.WriteLine("You stayed");
                                    Console.WriteLine("You have " + playersum);

                                }
                                else if (rollanswer == "roll")
                                {
                                    Random rand = new Random();
                                    int playerthrow = rand.Next(1, 7);
                                    playersum += playerthrow;
                                    Console.WriteLine("You rolled " + playerthrow);
                                    Console.WriteLine("You have " + playersum);
                                }
                            }
                            else if (wowguy == 2)
                            {
                                Console.WriteLine("Dealer stayed");
                                Console.WriteLine("Dealer has " + dealersum);
                                turn = 0;
                                Console.WriteLine("Would you like to roll or stay?");
                                string answer3 = Console.ReadLine();
                                if (answer3 == "stay")
                                {
                                    Console.WriteLine("You stayed");
                                    Console.WriteLine("You have " + playersum);
                                    GameOngoing = 1;
                                }
                                else if (answer3 == "roll")
                                {
                                    Random rand = new Random();
                                    int playerthrow = rand.Next(1, 7);
                                    playersum += playerthrow;
                                    Console.WriteLine("You rolled " + playerthrow);
                                    Console.WriteLine("You have " + playersum);
                                }

                            }
                        }


                    }
                    else
                    {
                        GameOngoing = 1;
                    }
                }
            }

            if (playersum > 21 && dealersum > 21)
            {

                Console.WriteLine("");
                Console.WriteLine("Both lose");
            }
            else if (playersum == dealersum)
            {
                Console.WriteLine("");
                Console.WriteLine("You both have the same amount no one won");
            }
            else if (dealersum > 21 || playersum == 21 || playersum > dealersum || playersum <= 21 && dealersum != 21)
            {
                Console.WriteLine("You won!");
                Console.WriteLine("");
                Console.WriteLine("Dealer had " + dealersum);
                Console.WriteLine("You had " + playersum);

            }
            else if (playersum > 21 || dealersum == 21 || dealersum > playersum || dealersum <= 21 && playersum != 21)
            {
                Console.WriteLine("You lose.");
                Console.WriteLine("");
                Console.WriteLine("Dealer had " + dealersum);
                Console.WriteLine("You had " + playersum);
            }
        }
    }
}

















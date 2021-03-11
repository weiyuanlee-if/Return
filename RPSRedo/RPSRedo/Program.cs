using System;

namespace RPSRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            string playerName;
            string playerChoice;
            int rounds = 1;
            int playerWin = 0;
            int playerLose = 0;
            int computerWin = 0;
            int computerLose = 0;
            int playersDraw = 0;

            
                Console.WriteLine("Let's play Rock, Paper, Scissors! ;)");
                Console.WriteLine("What is your name?");
                string playerNameInput = Console.ReadLine();
                playerName = playerNameInput;
                Console.WriteLine("Hello, {0}", playerName);
                Console.WriteLine("You ready?");
            while (rounds < 6)
            {
                Console.WriteLine("Round {0}", rounds); //round counter?
                Console.WriteLine("What will you choose? Rock, Paper, Scissors?");
                string playerChoiceInput = Console.ReadLine();
                playerChoice = playerChoiceInput;


                string[] computerChoices = new string[3] { "Rock", "Paper", "Scissors" };
                Random computerChoiceInput = new Random();
                int c = computerChoiceInput.Next(0, 3);
                Console.WriteLine("Computer: {0}", computerChoices[c]);


                if (playerChoice == "Rock")
                {
                    Console.WriteLine("You chose: Rock");
                }
                else if (playerChoice == "Paper")
                {
                    Console.WriteLine("You chose: Paper");
                }
                else if (playerChoice == "Scissors")
                {
                    Console.WriteLine("You chose: Scissors");
                }
                else
                {
                    Console.WriteLine("That's not an RPS move, sorry?");
                }
                #endregion


                #region
                if (playerChoice == "Paper" && computerChoices[c] == "Paper" || (playerChoice == "Rock" && computerChoices[c] == "Rock" || (playerChoice == "Scissors" && computerChoices[c] == "Scissors")))
                {
                    Console.WriteLine("Draw!");
                    rounds += 1;
                    playersDraw += 1;
                  

                }
                if (playerChoice == "Paper" && computerChoices[c] == "Rock" || playerChoice == "Scissors" && computerChoices[c] == "Paper" || playerChoice == "Rock" && computerChoices[c] == "Scissors")
                {
                    Console.WriteLine("You win!");
                    rounds += 1;
                    playerWin += 1;
                    computerLose -= 1;


                }
                if (computerChoices[c] == "Paper" && playerChoice ==  "Rock" || computerChoices[c] == "Scissors" && playerChoice == "Paper" || computerChoices[c] == "Rock" && playerChoice == "Scissors")
                {
                    Console.WriteLine("You lose!");
                    rounds += 1;
                    computerWin += 1;
                    playerLose -= 1;


                }
               while (rounds == 6)
                {
                    Console.WriteLine("Game over");
                    if(playerWin == 5)
                    {
                        Console.WriteLine("Cheers, you won!");
                    } else if(playerWin < 5)
                    {
                        Console.WriteLine("Bummer, you lost");
                    }
                            
                    break;
                   
               

                  
               

                }
                #endregion
            }






        }

        
        }
            }
        
    

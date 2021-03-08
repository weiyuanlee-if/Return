using System;

namespace RPSRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            string playerChoice;

            Console.WriteLine("Let's play Rock, Paper, Scissors! ;)");
            Console.WriteLine("What is your name?");
            string playerNameInput = Console.ReadLine();
            playerName = playerNameInput;
            Console.WriteLine("Hello, {0}", playerName);
            Console.WriteLine("You ready?");
            Console.WriteLine("Round {0}"); //round counter?
            Console.WriteLine("What will you choose? Rock, Paper, Scissors?");
            string playerChoiceInput = Console.ReadLine();
            playerChoice = playerChoiceInput;
            ComputerChoice();

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

            

           





        }
        public static void ComputerChoice()
        {
            Random computerChoice = new Random();
            int computerChoiceInput;
            computerChoiceInput = computerChoice.Next(1, 3);

            switch (computerChoiceInput)
            {
                case 1:
                    {
                        Console.WriteLine("Computer Chose: Rock");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Computer Chose: Paper");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Computer Chose: Scissors");
                    }
                    break;
            }
        }
    }
}

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
            Console.WriteLine("Let's see who goes first.");
            playerChoice = Console.ReadLine();

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
        public void ComputerChoice()
        {
            Random computerChoice = new Random();
            int computerChoiceInput;
            computerChoiceInput = computerChoice.Next(1, 4);

            switch (computerChoice)
            {
                case 1:
                    {
                        Console.WriteLine("");
                    }
            }
        }
    }
}

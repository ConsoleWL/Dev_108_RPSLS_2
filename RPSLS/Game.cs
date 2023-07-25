using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        int numberOfHumanPlayers;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");

            Console.WriteLine("Rock crushes Schissors");
            Console.WriteLine("Rock crushes Lizard");

            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disproves Spock");

            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Scissors cuts Paper");

            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");

            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Spock smashes Scissors");

            Console.WriteLine("\nGame will be best out of 3!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nChoose number of players 1 or 2:");

            while (true)
            {
                string temp = Console.ReadLine();

                if (temp == "1")
                {
                    return 1;
                }
                if (temp == "2")
                {
                    return 2;
                }
                else
                {
                    Console.WriteLine("\nWrong input. Choose between 1 or 2:");
                }
            }
            
            
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer("Nikita");
                playerTwo = new ComputerPlayer("Computer");
            }
            if (numberOfHumanPlayers == 2)
            {
                playerOne = new HumanPlayer("Nikita");
                playerTwo = new HumanPlayer("Michael");
            }
        }

        public void CompareGestures()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                Console.WriteLine();

                // logic for ties
                if (playerOne.chosenGesture.name == "rock" && playerTwo.chosenGesture.name == "rock")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "paper" && playerTwo.chosenGesture.name == "paper")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "scissors" && playerTwo.chosenGesture.name == "scissors")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "lizard" && playerTwo.chosenGesture.name == "lizard")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "Spock" && playerTwo.chosenGesture.name == "Spock")
                {
                    Console.WriteLine("Tied, Try again");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for rock
                else if (playerOne.chosenGesture.name == "rock" && playerTwo.chosenGesture.name == "scissors")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "rock" && playerTwo.chosenGesture.name == "lizard")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                // logic for paper
                else if (playerOne.chosenGesture.name == "paper" && playerTwo.chosenGesture.name == "rock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "paper" && playerTwo.chosenGesture.name == "Spock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for scissors
                else if (playerOne.chosenGesture.name == "scissors" && playerTwo.chosenGesture.name == "paper")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "scissors" && playerTwo.chosenGesture.name == "lizard")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for lizard
                else if (playerOne.chosenGesture.name == "lizard" && playerTwo.chosenGesture.name == "Spock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "lizard" && playerTwo.chosenGesture.name == "paper")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for Spock
                else if (playerOne.chosenGesture.name == "Spock" && playerTwo.chosenGesture.name == "scissors")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                else if (playerOne.chosenGesture.name == "Spock" && playerTwo.chosenGesture.name == "rock")
                {
                    playerOne.score++;
                    Console.WriteLine($"{playerOne.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }
                //logic for playerTwo
                else
                {
                    playerTwo.score++;
                    Console.WriteLine($"{playerTwo.name} wins the round");
                    Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score} ");
                }

                Console.WriteLine("________________________________________________");
            }
        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            CompareGestures();
        }
    }
}

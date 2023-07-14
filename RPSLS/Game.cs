using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Let's play a game.... Here are the rules:\n" +
                "Rock crushes Scissors\r\n" +
                "Scissors cuts Paper \r\n" +
                "Paper covers Rock\r\n" +
                "Rock crushes Lizard\r\n" +
                "Lizard poisons Spock\r\n" +
                "Spock smashes Scissors\r\n" +
                "Scissors decapitates Lizard\r\n" +
                "Lizard eats Paper\r\n" +
                "Paper disproves Spock\r\n" +
                "Spock vaporizes Rock\r\n\n" +
                "We will be playing 3 rounds, best 2 of 3 wins!!\n");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many people will be playing? 1 or 2?\n");
            string numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers == "1")
                return 1;

            else if (numberOfPlayers == "2")
                return 2;

            else
            {
                Console.WriteLine("Too many players! Try again!\n");
                return ChooseNumberOfHumanPlayers();
            }
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if(numberOfHumanPlayers == 2)
            {              
                Console.WriteLine("Player One, what is your name?\n");
                playerOne = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("Player Two, what is your name?\n");
                playerTwo = new HumanPlayer(Console.ReadLine());
            }
            else if(numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Player One, what is your name");
                playerOne = new HumanPlayer(Console.ReadLine());
                playerTwo = new ComputerPlayer("EDI");
            }
        }

        public void CompareGestures()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                    Console.WriteLine("It's a tie! Start over!\n");
                }
                else if (
                         (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors") ||
                         (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard") ||
                         (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper") ||
                         (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard") ||
                         (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock") ||
                         (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock") ||
                         (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock") ||
                         (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper") ||
                         (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors") ||
                         (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock"))
                {
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;

                }
                else
                {
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
            }
        }

        public void DisplayGameWinner()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} has won the game. Better luck next time {playerTwo.name}...");
            }
            else if(playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} has won the game. Better luck next time {playerOne.name}...");
            }
        }

        


        public void RunGame()
        {
            WelcomeMessage(); 
            int numPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numPlayers);
            CompareGestures();
            DisplayGameWinner();
        }
    }
}

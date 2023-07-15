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
                Console.WriteLine("Player One, what is your name?\n");
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

                Console.WriteLine($"{playerOne.name} has chosen {playerOne.chosenGesture}.\n");
                Console.WriteLine($"{playerTwo.name} has chosen {playerTwo.chosenGesture}.\n");

                if (playerOne.chosenGesture == playerTwo.chosenGesture)
                {
                    Console.WriteLine("It's a tie! Start over!\n");
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Rock crushes scissors!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Rock crushes lizard!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Scissors cuts paper!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Scissors decapitates lizard!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Paper covers rock!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Paper disproves Spock!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Lizard poisons Spock!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Lizard eats paper!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Spock smashes scissors!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Spock vaporizes rock!\n");
                    Console.WriteLine($"{playerOne.name} wins that round!\n");
                    playerOne.score++;
                }
                else if (playerTwo.chosenGesture == "rock" && playerOne.chosenGesture == "scissors")
                {
                    Console.WriteLine("Rock crushes scissors!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "rock" && playerOne.chosenGesture == "lizard")
                {
                    Console.WriteLine("Rock crushes lizard!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "scissors" && playerOne.chosenGesture == "paper")
                {
                    Console.WriteLine("Scissors cut paper!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "scissors" && playerOne.chosenGesture == "lizard")
                {
                    Console.WriteLine("Scissors decapitates lizard!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "paper" && playerOne.chosenGesture == "rock")
                {
                    Console.WriteLine("Paper covers rock!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "paper" && playerOne.chosenGesture == "spock")
                {
                    Console.WriteLine("Paper disproves Spock!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "lizard" && playerOne.chosenGesture == "spock")
                {
                    Console.WriteLine("Lizard poisons Spock!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if (playerTwo.chosenGesture == "lizard" && playerOne.chosenGesture == "paper")
                {
                    Console.WriteLine("Lizard eats paper!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if(playerTwo.chosenGesture == "spock" && playerOne.chosenGesture == "scissors")
                {
                    Console.WriteLine("Spock smashes scissors!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else if(playerTwo.chosenGesture == "spock" && playerOne.chosenGesture == "rock")
                {
                    Console.WriteLine("Spock vaporizes rock!\n");
                    Console.WriteLine($"{playerTwo.name} wins that round!\n");
                    playerTwo.score++;
                }
                else
                {
                    Console.WriteLine("Invalid input on one or more players! Choose again!\n");
                }

            }
        }

        public void DisplayGameWinner()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} has won the game. Better luck next time {playerTwo.name}...\n");
            }
            else if(playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} has won the game. Better luck next time {playerOne.name}...\n");
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

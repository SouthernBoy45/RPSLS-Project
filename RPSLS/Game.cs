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
                "We will be playing 3 rounds, best 2 of 3 wins!!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many people will be playing? 1 or 2?");
            string numberOfPlayers = Console.ReadLine();

            if (numberOfPlayers == "1")
            {
                Console.WriteLine("Player One, what is your name?");
                string playerOne = Console.ReadLine();
                return 1;
            }
            else if (numberOfPlayers == "2")
            {
                Console.WriteLine("Player One, what is your name?");
                string playerOne = Console.ReadLine();

                Console.WriteLine("Player Two, what is your name?");
                string playerTwo = Console.ReadLine();
                return 2;
            }
            else
            {
                Console.WriteLine("Too many players! Start over!");
                return 0;
            }
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}

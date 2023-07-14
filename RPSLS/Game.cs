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
                "We will be playing 3 rounds, best 2 of 3 wins!!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many people will be playing? 1 or 2?");
            string numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers == "1")
                return 1;

            else if (numberOfPlayers == "2")
                return 2;

            else
            {
                Console.WriteLine("Too many players! Try again!");
                return ChooseNumberOfHumanPlayers();
            }
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if(numberOfHumanPlayers == 2)
            {              
                Console.WriteLine("Player One, what is your name?");
                playerOne = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("Player Two, what is your name?");
                playerTwo = new HumanPlayer(Console.ReadLine());
            }
            else if(numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Player One, what is your name?");
                this.playerOne = new HumanPlayer(Console.ReadLine());
                this.playerTwo = new ComputerPlayer("EDI");
            }
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
            //I need something to hold the value of the choose#ofplayers. 
            int numPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numPlayers);
        }
    }
}

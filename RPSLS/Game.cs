using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables (HAS A)
        public Player playerOne;
        public Player playerTwo;
        public int playerOnePoint;
        public int playerTwoPoint;

        //constructor
        public Game()
        {

        }

        //member methods (CAN DO)
        //need a method to accept user's input if they are playing against a human or computer - this is where inheritance comes into play
        //if human vs human than ***something*** (maybe use console readline to accept user input?) else ---> ????
        //need a method to compare the gestures 
        //everytime a player's gesture wins a round, add the score to their running total
        //the first player to 2 wins, wins the game

        public void Welcome()
        {
            Console.WriteLine("Welcome to ROCK, PAPER, SCISSOR, LIZARD, SPOCK");
        }

        public void VerifySecondPlayer()
        {
            bool inputCheck = true;
            while (inputCheck)
            {
                Console.WriteLine("How Many Players Will be Playing?  Type '1' for SINGLE Player or '2' for TWO Players");
                string verifyPlayerQuantity = Console.ReadLine();
                switch (verifyPlayerQuantity)
                {
                    case "1":
                    case "one":
                        playerOne = new Human();
                        playerTwo = new Computer();
                        inputCheck = false;
                        break;
                    case "2":
                        playerOne = new Human();
                        playerTwo = new Human();
                        inputCheck = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        VerifySecondPlayer();
                        break;
                }
            }
        }

        public void CompareGestures()
        {
            
        }
    }
}

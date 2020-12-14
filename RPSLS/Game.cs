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
        public int playerOneScore;
        public int playerTwoScore;

        //constructor
        public Game()
        {

        }

        //member methods (CAN DO)
        public void Welcome()
        {
            Console.WriteLine("Welcome to ROCK, PAPER, SCISSOR, LIZARD, SPOCK");
        }
        public void VerifySecondPlayer()
        {
            bool inputCheck = true;
            while (inputCheck)
            {
                Console.WriteLine("How Many Players Will be Playing?  Type '1' for ONE Player or '2' for TWO Players");
                string verifyPlayerQuantity = Console.ReadLine();
                switch (verifyPlayerQuantity)
                {
                    case "1":
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
                        break;
                }
            }
        }
        public void CompareGestures()
        {
            if (playerOne.chosenGesture == "ROCK" && playerTwo.chosenGesture == "ROCK" || playerOne.chosenGesture == "PAPER" && playerTwo.chosenGesture == "PAPER" || playerOne.chosenGesture == "SCISSOR" && playerTwo.chosenGesture == "SCISSOR" || playerOne.chosenGesture == "LIZARD" && playerTwo.chosenGesture == "LIZARD" || playerOne.chosenGesture == "SPOCK" && playerTwo.chosenGesture == "SPOCK")
            {
                Console.WriteLine("It's a Tie!");
            }
            else if (playerOne.chosenGesture == "ROCK" && playerTwo.chosenGesture == "SCISSOR" || playerOne.chosenGesture == "ROCK" && playerTwo.chosenGesture == "LIZARD" || playerOne.chosenGesture == "PAPER" && playerTwo.chosenGesture == "SPOCK" || playerOne.chosenGesture == "PAPER" && playerTwo.chosenGesture == "ROCK" || playerOne.chosenGesture == "SCISSOR" && playerTwo.chosenGesture == "PAPER" || playerOne.chosenGesture == "SCISSOR" && playerTwo.chosenGesture == "LIZARD" || playerOne.chosenGesture == "LIZARD" && playerTwo.chosenGesture == "SPOCK" || playerOne.chosenGesture == "LIZARD" && playerTwo.chosenGesture == "PAPER" || playerOne.chosenGesture == "SPOCK" && playerTwo.chosenGesture == "SCISSOR" || playerOne.chosenGesture == "SPOCK" && playerTwo.chosenGesture == "ROCK")
            {
                Console.WriteLine("Player 1 won this round!");
                playerOneScore++;
            }
            else
            {
                Console.WriteLine("Player 2 won this round!");
                playerTwoScore++;
            }
        }
        public void TrackScore()
        {
            Console.WriteLine("Player 1 has " + playerOneScore + " points");
            Console.WriteLine("Player 2 has " + playerTwoScore + " points");
        }
        public void DisplayWinner()
        {
            {
                if (playerOneScore == 3)
                {
                    Console.WriteLine("PLAYER 1 WINS THE GAME!!!!!");
                }
                else if (playerTwoScore == 3)
                {
                    Console.WriteLine("PLAYER 2 WINS THE GAME!!!!!");
                }
            }
        }
        public void StartGame()
        {
            Welcome();
            VerifySecondPlayer();
            while (playerOneScore < 3 && playerTwoScore < 3)
            {
                playerOne.SelectGesture();
                playerTwo.SelectGesture();
                CompareGestures();
                TrackScore();
            }
            DisplayWinner();
        }
    }
}

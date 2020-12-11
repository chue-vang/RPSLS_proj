using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //member variables (HAS A)
        public int playerOne;
        public int playerTwo;

        //constructor
        public Human(int PlayerOne, int PlayerTwo)
        {
            this.playerOne = PlayerOne;
            this.playerTwo = PlayerTwo;
        }

        //member methods (CAN DO)

        //what can a human player do??
        //a human player can choose which gestures to use
        //the human user will need to select their gesture from a list, will need to validate their input

        public void PlayerOneSelectGesture(Player selectGesture)
        {            
            Console.WriteLine("Player 1, please select your gesture from the list: Rock=0, Paper=2, Scissor=3, Lizard=4, Spock=5");
            foreach(string gestures in gestures)
            {
                Console.WriteLine(gestures);
            }
            int userInput = Int32.Parse(Console.ReadLine());            
        }

        public void PlayerTwoSelectGesture(Player selectGesture2)
        {
            Console.WriteLine("Player 2, please select your gesture from the list: Rock=0, Paper=2, Scissor=3, Lizard=4, Spock=5");
            foreach(string gestures in gestures)
            {
                Console.WriteLine(gestures);
            }
            int userInput2 = Int32.Parse(Console.ReadLine());
        }
    }
}

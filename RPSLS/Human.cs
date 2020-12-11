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


        //constructor
        public Human()
        {

        }

        public override void PlayerOneChosenGesture()
        {
            throw new NotImplementedException();
        }

        //member methods (CAN DO)

        //what can a human player do??
        //a human player can choose which gestures to use
        //the human user will need to select their gesture from a list, will need to validate their input

        public void PlayerOneSelectGesture()
        {            
            Console.WriteLine("Player 1, please select your gesture from the list: Rock=1, Paper=2, Scissor=3, Lizard=4, Spock=5");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + gestures[i]);
            }
            //int playerOneSelectedGesture = Int32.Parse(Console.ReadLine());
            //chosenGesture = gestures[playerOneSelectedGesture];

            //make a switch case
        }

    }
}

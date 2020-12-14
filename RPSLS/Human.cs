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

        //public override void PlayerChosenGesture()
        //{
        //    throw new NotImplementedException();
        //}

        //member methods (CAN DO)

        //what can a human player do??
        //a human player can choose which gestures to use
        //the human user will need to select their gesture from a list, will need to validate their input

        public override void SelectGesture() // Selecting a gesture
        {
            // how do we set the PLayer's chosenGesture member variable equal to their selection
            bool inputCheck = true;
            while (inputCheck)
            {
                Console.WriteLine("Player 1 select your gesture: 1=ROCK, 2=PAPER, 3=SCISSOR, 4=LIZARD, 5=SPOCK");
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine((i + 1) + " " + gestures[i]);
                }
                string selectGesture = Console.ReadLine();
                switch (selectGesture)
                {
                    case "1":
                        Console.WriteLine("Player 1 selects ROCK");
                        chosenGesture = gestures[0];
                        inputCheck = false;
                        break;
                    case "2":
                        Console.WriteLine("Player 1 selects PAPER");
                        chosenGesture = gestures[1];
                        inputCheck = false;
                        break;
                    case "3":
                        Console.WriteLine("Player 1 selects SCISSOR");
                        chosenGesture = gestures[2];
                        inputCheck = false;
                        break;
                    case "4":
                        Console.WriteLine("Player 1 selects LIZARD");
                        chosenGesture = gestures[3];
                        inputCheck = false;
                        break;
                    case "5":
                        Console.WriteLine("Player 1 selects SPOCK");
                        chosenGesture = gestures[4];
                        inputCheck = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
            
        }
    }
}

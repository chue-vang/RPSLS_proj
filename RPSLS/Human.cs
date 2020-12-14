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

        public override void SelectGesture()
        {
            bool inputCheck = true;
            while (inputCheck)
            {
                Console.WriteLine("Please select your gesture: 1=ROCK, 2=PAPER, 3=SCISSOR, 4=LIZARD, 5=SPOCK");
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine((i + 1) + " " + gestures[i]);
                }
                string selectGesture = Console.ReadLine();
                switch (selectGesture)
                {
                    case "1":
                        Console.WriteLine("ROCK has been selected");
                        chosenGesture = gestures[0];
                        inputCheck = false;
                        break;
                    case "2":
                        Console.WriteLine("PAPER has been selected");
                        chosenGesture = gestures[1];
                        inputCheck = false;
                        break;
                    case "3":
                        Console.WriteLine("SCISSOR has been selected");
                        chosenGesture = gestures[2];
                        inputCheck = false;
                        break;
                    case "4":
                        Console.WriteLine("LIZARD has been selected");
                        chosenGesture = gestures[3];
                        inputCheck = false;
                        break;
                    case "5":
                        Console.WriteLine("SPOCK has been selected");
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

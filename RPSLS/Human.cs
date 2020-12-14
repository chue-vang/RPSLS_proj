﻿using System;
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

        public void SelectGesture()
        {
            bool inputCheck = true;
            while (inputCheck)
            {
                Console.WriteLine("Please select your gesture from the list, by entering the correct number: ROCK=1, PAPER=2, SCISSOR=3, LIZARD=4, SPOCK=5");
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine((i + 1) + " " + gestures[i]);
                }
                string selectGesture = Console.ReadLine();
                switch (selectGesture)
                {
                    case "1":
                    case "one":
                        chosenGesture = selectGesture;
                        inputCheck = false;
                        break;
                    case "2":
                    case "two":
                        chosenGesture = selectGesture;
                        inputCheck = false;
                        break;
                    case "3":
                    case "three":
                        chosenGesture = selectGesture;
                        inputCheck = false;
                        break;
                    case "4":
                    case "four":
                        chosenGesture = selectGesture;
                        inputCheck = false;
                        break;
                    case "5":
                    case "five":
                        chosenGesture = selectGesture;
                        inputCheck = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        SelectGesture();
                        break;
                }
            }
            
        }
    }
}

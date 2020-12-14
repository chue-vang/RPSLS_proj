using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            //test console writeline
            //Game game = new Game();
            //game.Welcome();
            //Console.ReadLine();

            //Game test = new Game();
            //test.VerifySecondPlayer();
            //Console.ReadLine();

            //Human test = new Human();
            //test.SelectGesture();
            //Console.ReadLine();

            Computer test = new Computer();
            test.GenerateRandomNumber();
            Console.ReadLine();

        }
    }
}

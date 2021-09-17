using System;
using Game_CE05;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            while (play)
            {
                //Play Game
                MathChallenge game = new MathChallenge();
                game.Play();

                //Play Again?
                play = PlayAgain();

            }
        }

        //Alow user to run application again
        private static bool PlayAgain()
        {
            Console.WriteLine(" \r\n =========================================");
            Console.Write(" Would you like to play again? [Y/N]: ");

            string response = Console.ReadLine().ToUpper();
            return (response == "Y") ? true : false;
        }
    }
}

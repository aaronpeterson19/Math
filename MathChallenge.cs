using System;
using System.Collections.Generic;



namespace Game_CE05
{
    public class MathChallenge
    {
        //Fields
        private string _title;
        private int _level;
        private int _score;
        private string _instructions = "Are you good at math? Put your wits to the test! The game is simple...you will be provided a math problem.Go for as long as you want to see what percent of questions you answered correctly. Quit whenever you'd like by simply typing in the letter [q].\r\n\r\n  • Solutions are rounded down\r\n  • Points awarded based on number of correct answers \r\n  • Make sure to round down for all answers";
        private bool _wrong;

        //Contructor
        public MathChallenge()
        {
            {
                _wrong = false;

                _score = 0;
                _level = 1;

            }



        }
        
        // Play
        public void Play()
        {
            Console.Clear();
            Console.WriteLine("\r\n==============================================");
            Console.WriteLine(" MATH CHALLENGE");
            Console.WriteLine("==============================================");
            

            //Display Instructions
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(_instructions);
            Console.ResetColor();
            Console.WriteLine("\r\n---------------------------------------------------------");
            {
                Problem.MathProblems();
                
                Console.Write("\nPress any key to exit...");
                Console.ReadKey();
                
               
            }


            
            
             
             


       

        }
        // Validate Integer
        private static int validateInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            int guess;

            while (!Int32.TryParse(input, out guess))
            {
                Console.Write(" Invalid input, Please enter a number! ");
                input = Console.ReadLine();

            }

            return guess;
        }
    } 
}

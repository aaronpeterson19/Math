using System;
using System.Collections.Generic;

// Name: Aaron Peterson

namespace Game_CE05
{
    public class Problem
    {

        public static void MathProblems()
        {


            var rnd = new Random();
            var quit = false;
            var userScore = 0;
            var totalProblems = 0;
            var percentCorrect = 0d;

            while (!quit)
            {


                var number1 = rnd.Next(1, 31);
                var number2 = rnd.Next(1, 31);
                var operation = rnd.Next(1, 5);
                string operatorString;
                int answer;
                totalProblems++;



                switch (operation)
                {
                    case 1:
                        answer = number1 + number2;
                        operatorString = "+";
                        break;
                    case 2:
                        answer = number1 - number2;
                        operatorString = "-";
                        break;
                    case 3:
                        answer = number1 * number2;
                        operatorString = "*";
                        break;
                    case 4:
                        answer = number1 / number2;
                        operatorString = "/";
                        break;
                    default:
                        answer = 0;
                        operatorString = "?";
                        break;
                }

                Console.WriteLine("---------------------------------------------------------\r\n{0} {1} {2} = ???", number1, operatorString, number2);


                var input = Console.ReadLine();
                int inputAsInt;

                while (!int.TryParse(input, out inputAsInt))
                {
                    Console.Write("Answer must be an integer. Try again: ");
                    input = Console.ReadLine();
                }

                if (inputAsInt == answer)
                {
                    Console.WriteLine("Correct!");
                    userScore++;
                }
                else
                {
                    Console.WriteLine("Sorry, the correct answer was: {0}", answer);
                }

                percentCorrect = Math.Round((double)userScore / totalProblems * 100, 2);

                Console.WriteLine($"\nYou have answered {userScore} of {totalProblems} questions correctly. ");


                Console.Write("\nPress 'q' to quit, or any other key to continue... ");
                if (Console.ReadKey().Key == ConsoleKey.Q) quit = true;

                int points = 0;
                if (percentCorrect <= 50)
                {
                    points = 0;
                }
                else if (percentCorrect <= 51)
                {
                    points = 10;
                }
                else if (percentCorrect <= 79)
                {
                    points = 15;
                }
                else if (percentCorrect <= 89)
                {
                    points = 20;
                }
                else if (percentCorrect <= 100)
                {
                    points = 50;
                }

                Console.WriteLine($"\r\n---------------------------------------------------------\n\nThank you for playing. You got a total of {percentCorrect}% correct!");
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private byte _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Start Quiz!!!");
            int questionNumber = 1; // to display question numbers

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResults();
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

            double percentage = (double)_score / _questions.Length;

            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work");
            }
            else if(percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good Work");
            }
            else 
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Practicing mate!");
            }
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Question                                ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" ");
                Console.Write(i + 1);
                Console.ResetColor();

                Console.WriteLine($". {question.Answers[i]}");
            }

            /*if (GetUserChoice() == question.CorrectAnswerIndex)
            {
                Console.WriteLine("Your answer is correct!!!");
            }
            else
            {
                Console.WriteLine("Wrong answer!!!");
            }*/
            
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Your anwser is: ");
            string user_input = Console.ReadLine();
            int choice = 0;
            while (!
                int.TryParse(user_input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Enter a choice between 1 and 4!");
                Console.ReadLine();

            }
            return choice - 1; // adjust to 0 indexed array

        }
    }
}

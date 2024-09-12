namespace MyQuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(question_text:"What is the capital of Nigeria?",
                             answers: new string[] {"Paris", "Abuja", "Niger"},
                             correctanswerindex: 1
                             ),
                new Question(question_text:"What is 10 + 10?",
                             answers: new string[] {"3", "4", "20"},
                             correctanswerindex: 2
                             ),

            };
            Quiz Quiz = new Quiz(questions);
            Quiz.StartQuiz();
            Console.ReadKey();
        }
    }
}

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
                             )
            };
            Quiz Quiz = new Quiz(questions);
            Quiz.DisplayQuestion(questions[0]);
            Console.ReadKey();
        }
    }
}

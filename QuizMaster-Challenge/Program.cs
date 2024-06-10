namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Quiz completed.");
            }
        }

        static void StartQuiz()
        {
            List<string> questions = new List<string>
        {
            "Which language is used for web development and also in Node.js?",
            "What is the keyword used to declare a variable in C#?",
            "What is the main function in a C# console application?",
            "What symbol is used to denote a comment in Python?",
            "Which language is known for its 'write once, run anywhere' capability?"
        };

            List<string> answers = new List<string>
        {
            "JavaScript",
            "var",
            "Main",
            "#",
            "Java"
        };

            int score = 0;

            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                string userAnswer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    Console.WriteLine("Invalid input. Please enter a valid answer.");
                    i--;
                    continue;
                }

                if (userAnswer.Equals(answers[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {answers[i]}.");
                }
            }

            Console.WriteLine($"Your final score is: {score}/{questions.Count}");
        }
    }
}
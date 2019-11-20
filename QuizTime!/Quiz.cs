using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime  
{
    class Quiz : Question
    {
        public List<Question> quiz = new List<Question>();
        public string Title { get; set; }
        public String[] answerStrings { get; set; }
        public double Score { get; set; }
        public double TotalPoints { get; set; }
        public string currentAnswer { get; set; }


        public Quiz(string title)
        {
            Title = title;

        }
        public List<Question> addQuestion(Question questionObject)
        {
            quiz.Add(questionObject);
            TotalPoints++;
            return quiz;
        }

        public void takeQuiz()
        {
            Console.WriteLine("Welcome to the " + Title + "!");
            Console.WriteLine("");

            foreach (Question item in quiz)
            {
                Console.WriteLine("Question " + (quiz.IndexOf(item) + 1) + ":");
                Console.WriteLine(item.QuestionString);
                Console.WriteLine("");
                
                foreach(string answer in item.Answers)
                {
                    Console.WriteLine(item.Answers.IndexOf(answer)+") "+answer);
                }
                Console.WriteLine("");
                currentAnswer = Console.ReadLine();
                String[] answerStrings = currentAnswer.Split(",");
                for (int i = 0; i < answerStrings.Length; i++)
                {
                    //Console.WriteLine("Answer " + answerStrings[i]);
                    foreach (int correctOne in item.CorrectAnswers)
                    {
                        if (Convert.ToInt32(answerStrings[i]) == correctOne)
                        {
                            Score++;
                            Console.WriteLine("Answer " + answerStrings[i] + " is correct!");
                        }
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("");

             
            }

        }
    }


    
}

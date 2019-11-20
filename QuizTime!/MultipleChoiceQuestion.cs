using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class MultipleChoiceQuestion:Question
    {
        
        public MultipleChoiceQuestion(string questionString, List<string> answers,
            int correctAnswers)
        {
            QuestionString = questionString;
            Answers = answers;
            CorrectAnswers.Add(correctAnswers);

        }
    }
}

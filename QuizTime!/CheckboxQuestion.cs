using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class CheckboxQuestion: Question
    {
     
        public CheckboxQuestion(string questionString, List<string> answers,
            List<int> correctAnswers)
        {
            QuestionString = questionString;
            Answers = answers;
            CorrectAnswers = correctAnswers;
        }
    }
}

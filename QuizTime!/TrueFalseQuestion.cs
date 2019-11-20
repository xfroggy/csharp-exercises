using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class TrueFalseQuestion: Question
    {
        public TrueFalseQuestion(string questionString, bool correctAnswers) 
        {
            QuestionString = questionString;
            Answers.Add("False");
            Answers.Add("True");
            if (correctAnswers == true)
            {
                CorrectAnswers.Add(1);

            }
            else
                CorrectAnswers.Add(0);
                
        }
    }
}

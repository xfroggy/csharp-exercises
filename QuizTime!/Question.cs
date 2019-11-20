using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Question
    {   
        public string QuestionString { get; set; }
        public List<string> Answers = new List<string>();
        public List<int> CorrectAnswers = new List<int>();
    }
}

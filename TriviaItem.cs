using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class TriviaItem
    {

        string[] aryTriviaQuestion;
        string[] aryTriviaAnswer;

        public void setQuestions()
        {
            aryTriviaQuestion = new string[10];
            aryTriviaQuestion[0] = "3 X 4 = ?";
            aryTriviaQuestion[1] = "Are you human?";
            aryTriviaQuestion[2] = "Whats a 4 year degree called?";
            aryTriviaQuestion[3] = "Are you really really sure your human?";
            aryTriviaQuestion[4] = "Can you walk?";
            aryTriviaQuestion[5] = "Will you have a good day?";
            aryTriviaQuestion[6] = "Can you do it";
            aryTriviaQuestion[7] = "Will you pass the class?";
            aryTriviaQuestion[8] = "4 x 4=?";
            aryTriviaQuestion[9] = "5+20=";
        }

        public void setAnswers()
        {
            aryTriviaAnswer = new string[10];
            aryTriviaAnswer[0] = "12";
            aryTriviaAnswer[1] = "yes";
            aryTriviaAnswer[2] = "bachelor";
            aryTriviaAnswer[3] = "yes";
            aryTriviaAnswer[4] = "yes";
            aryTriviaAnswer[5] = "yes";
            aryTriviaAnswer[6] = "yes";
            aryTriviaAnswer[7] = "yes";
            aryTriviaAnswer[8] = "16";
            aryTriviaAnswer[9] = "25";
        }

        public string getAnswer(int i)
        {
            return aryTriviaAnswer[i];
        }

        public string getQuestion(int i)
        {
            return aryTriviaQuestion[i];
        }







    }

}

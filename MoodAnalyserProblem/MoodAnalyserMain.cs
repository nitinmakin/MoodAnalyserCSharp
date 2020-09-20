using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
   public class MoodAnalyserMain
    {
        string message;

        public MoodAnalyserMain()
        {

        }
        
        public MoodAnalyserMain(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            return this.getMood(message);
        }
        public string getMood(string message)
        {
            try
            {
                if (message.Length == 0)

                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, "you have entered invalid input");

                if (message.Contains("sad"))

                    return "SAD";

                else

                    return "HAPPY";
            }catch(NullReferenceException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_NULL, "you have entered invalid input");
            }
        }

    }
}

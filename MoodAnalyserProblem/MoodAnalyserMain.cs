using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
   public class MoodAnalyserMain
    {
        string message;

        public MoodAnalyserMain(string message)
        {
            this.message = message;
        }
        public string getMood()
        {
            if (message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }

    }
}

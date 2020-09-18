using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
   public class MoodAnalyserMain
    {
        public string getMood(string message)
        {
            if (message.Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }

    }
}

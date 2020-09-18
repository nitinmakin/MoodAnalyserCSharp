﻿using System;
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
            try
            {
                if (message.Length == 0)

                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, "you have entered invalid input");

                if (message.Equals(null))

                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_NULL, "you have entered invalid input");

                if (message.Contains("sad"))

                    return "SAD";

                else

                    return "HAPPY";
            }catch(Exception e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_NULL, "you have entered invalid input");
            }
        }

    }
}

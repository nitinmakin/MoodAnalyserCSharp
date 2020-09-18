using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
   public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            INVALID_INPUT

        }

        public ExceptionType type;
        String message;

        public MoodAnalyserException(ExceptionType type, String message)
        {
            this.type = type;
            this.message = message;
           
        }
    }
}

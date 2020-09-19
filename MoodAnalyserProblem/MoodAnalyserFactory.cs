using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyserProblem
{
  public class MoodAnalyserFactory
    {
        public static MoodAnalyserMain GetMoodAnalyserObject(string className )
        {
           Assembly excutingAssambly = Assembly.GetExecutingAssembly();
           Type type = excutingAssambly.GetType(className);
           MoodAnalyserMain MoodAnalyserMainObject = (MoodAnalyserMain)Activator.CreateInstance(type);
           return MoodAnalyserMainObject;
        }
    }
}

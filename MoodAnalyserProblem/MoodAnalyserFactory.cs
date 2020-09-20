using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyserProblem
{
  public class MoodAnalyserFactory
    {
        public static ConstructorInfo ConstructorCreator()
        {
            try
            {
                Type type = typeof(MoodAnalyserMain);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor[0];
            }
            catch (Exception e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
            }
        }

        public static ConstructorInfo ConstructorCreator(string ClassNmae)
        {
            try
            {
                Type type = Type.GetType(ClassNmae);
                ConstructorInfo[] constructor = type.GetConstructors();
                return constructor[0];
            }
            catch (Exception e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
            }
        }

        public static ConstructorInfo ConstructorCreator(int noOfParameters)
        {
            try
            {
                Type type = typeof(MoodAnalyserMain);
                ConstructorInfo[] constructor = type.GetConstructors();
                foreach (ConstructorInfo index in constructor)
                {
                    int numberOfParam = index.GetParameters().Length;
                    while (numberOfParam == noOfParameters)
                    {
                        return index;
                    }
                }
                return constructor[0];
            }
            catch (Exception e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
            }
        }



        public static object InstanceCreator(string className, ConstructorInfo constructor)
        {
            try
            {
                Assembly excutingAssambly = Assembly.GetExecutingAssembly();
                Type type = excutingAssambly.GetType(className);
                MoodAnalyserMain reflectionGenratedObject = (MoodAnalyserMain)Activator.CreateInstance(type);
                return reflectionGenratedObject;
            }
            catch (Exception e)
            {                
               return new MoodAnalyserException(MoodAnalyserException.ExceptionType.INVALID_INPUT,"invalid input");
            }

        }
        public object InstanceCreator(string className, ConstructorInfo constructor, string message)
        {
            try
            {
                Assembly excutingAssambly = Assembly.GetExecutingAssembly();
                Type type = excutingAssambly.GetType(className);
                object reflectionGenratedObject = Activator.CreateInstance(type, message);
                return reflectionGenratedObject;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}

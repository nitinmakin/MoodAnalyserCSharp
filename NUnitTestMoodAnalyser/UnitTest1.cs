using MoodAnalyserProblem;
using NUnit.Framework;
using System;
using System.Reflection;

namespace NUnitTestMoodAnalyser
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenGivenSadMessageShouldReturnSad()
        {
            try
            {
                MoodAnalyserMain m = new MoodAnalyserMain("i am in sad mood");
                string result = m.AnalyseMood(); 
                Assert.AreEqual("SAD", result);
            }
            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.INVALID_INPUT, "YOU HAVE ENTERED AN INVALID INPUT");
            }
        }

        [Test]
        public void WhenGivenHappyMessageShouldReturnHappy()
        {
            try
            {
                MoodAnalyserMain m = new MoodAnalyserMain("i am in any mood");
                string result = m.AnalyseMood();
                Assert.AreEqual("HAPPY", result);
            }
            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.INVALID_INPUT, "YOU HAVE ENTERED AN INVALID INPUT");
            }
        }

        [Test]
        public void WhenGivenNullMessageShouldThrowMoodAnalyserException()
        {
            try
            {
                MoodAnalyserMain m = new MoodAnalyserMain(null);
                string result = m.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.ENTERED_NULL, e.type);
            }
        }

        [Test]
        public void WhenGivenEmptyMessageShouldThrowMoodAnalyserException()
        {
            try
            {
                MoodAnalyserMain m = new MoodAnalyserMain("");
                string result = m.AnalyseMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, e.type);
            }
        }

        [Test]
        public void WhenGivenMoodAnalyserNameShouldReturnMoodAnalyserObject()
        {
            try
            {
                ConstructorInfo constructorInfo = MoodAnalyserFactory.ConstructorCreator();
                MoodAnalyserMain obj = (MoodAnalyserMain)MoodAnalyserFactory.InstanceCreator
                ("MoodAnalyserProblem.MoodAnalyserMain", constructorInfo);
                Assert.IsInstanceOf(typeof(MoodAnalyserMain), obj);
                Console.WriteLine("try");
            }
            catch (MoodAnalyserException e)
            {

                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, "wrong file");
            }
        }
        [Test]
        public void WhenGivenMoodAnalyserWithWrongNameShouldThrowMoodAnalyserException()
        {
            try
            {
                ConstructorInfo constructorInfo = MoodAnalyserFactory.ConstructorCreator();
                object obj = MoodAnalyserFactory.InstanceCreator("MoodAnalyserMain1234", constructorInfo);
                MoodAnalyserMain m = new MoodAnalyserMain();
                Console.WriteLine("try");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.type);
                Console.WriteLine("catch");

            }
        }
        [Test]
        public void WhenGivenMoodAnalyserWithWrongConstructorShouldThrowMoodAnalyserException()
        {
            try
            {
                String className = "MoodAnalyser";
                ConstructorInfo constructorInfo = MoodAnalyserFactory.ConstructorCreator(className);
                MoodAnalyserMain obj = (MoodAnalyserMain)MoodAnalyserFactory.InstanceCreator
                ("MoodAnalyserProblem.MoodAnalyserMain", constructorInfo);
                MoodAnalyserMain m = new MoodAnalyserMain("abc");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.type);
            }
        }
        [Test]
        public void WhenGivenMoodAnalyser_WithParameterConstructor_ProperNameShouldReturnMoodAnalyserObject()
        {
            try
            {
                ConstructorInfo constructorInfo = MoodAnalyserFactory.ConstructorCreator(3);
                MoodAnalyserMain obj = (MoodAnalyserMain)MoodAnalyserFactory.InstanceCreator
                ("MoodAnalyserProblem.MoodAnalyserMain", constructorInfo, "i am in happy mood");
                Assert.IsInstanceOf(typeof(MoodAnalyserMain), obj);
            }
            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, "wrong file");
            }
        }
        [Test]
        public void WhenGivenMoodAnalyser_WithParameterConstructor_WrongClass_NameShouldThrowMoodAnalyserException()
        {
            try
            {
                ConstructorInfo constructorInfo = MoodAnalyserFactory.ConstructorCreator();
                MoodAnalyserMain obj = (MoodAnalyserMain)MoodAnalyserFactory.InstanceCreator
                ("MoodAnalyserProblem.MoodAnalyserMain123", constructorInfo, "i am in happy mood");

            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.type);
            }
        }
        [Test]
        public void WhenGivenMoodAnalyser_WithParameterConstructor_WhenWrongConstructor_NameShouldThrowMoodAnalyserException()
        {
            try
            {
                String className = "MoodAnalyser";
                ConstructorInfo constructorInfo = MoodAnalyserFactory.ConstructorCreator(className);
                MoodAnalyserMain obj = (MoodAnalyserMain)MoodAnalyserFactory.InstanceCreator
                ("MoodAnalyserProblem.MoodAnalyserMain123", constructorInfo, "i am in happy mood");

            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.type);
            }
        }
        [Test]
        public void WhenGivenHappyMessage_UsingReflection_ShouldReturnHappy()
        {
            try
            {
                string message = MoodAnalyserFactory.getMethod("MoodAnalyserProblem.MoodAnalyserMain", "getMood", "happy");
                Assert.AreEqual("HAPPY", message);
            }
            catch (MoodAnalyserException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, "wrong file");
            }
        }
        [Test]
        public void WhenGivenHappyMessageUsingReflection_WhenImproperMethod_ShouldReturnHappy()
        {
            try
            {
                string message = MoodAnalyserFactory.getMethod("MoodAnalyserProblem.MoodAnalyserMain", "WrongMethodName", "happy");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.type);           
            }
        }
        [Test]
        public void Change_Mood_Dynamically()
        {
            dynamic result = MoodAnalyserFactory.ChangeTheMood("MoodAnalyserProblem.MoodAnalyserMain", "happy");
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void ChangeMoodDynamically_WhenNull_ShouldThrowException()
        {
            try
            {
                dynamic result = MoodAnalyserFactory.ChangeTheMood("MoodAnalyserProblem.MoodAnalyserMain", null);
            }catch(MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.ENTERED_NULL, e.type);
            }
        }

    }
}
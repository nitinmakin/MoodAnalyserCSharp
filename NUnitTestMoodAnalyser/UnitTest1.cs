using MoodAnalyserProblem;
using NUnit.Framework;

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
                string result = m.getMood(); ;
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
                string result = m.getMood();
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
                string result = m.getMood();
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
                string result = m.getMood();
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
                MoodAnalyserMain obj = MoodAnalyserFactory.GetMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyserMain");
                MoodAnalyserMain m = new MoodAnalyserMain();
                Assert.IsTrue(obj.ToString().Equals(m.ToString()));
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
                MoodAnalyserMain obj = MoodAnalyserFactory.GetMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyserMainabc");
                MoodAnalyserMain m = new MoodAnalyserMain();
                
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT,e.type);
               
            }
        }
    }
}
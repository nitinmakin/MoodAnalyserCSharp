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
    }
}
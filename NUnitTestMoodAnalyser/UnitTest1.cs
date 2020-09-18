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
        public void WhenGivenNullMessageShouldReturnHappy()
        {
            MoodAnalyserMain m = new MoodAnalyserMain("");
            string result = m.getMood();
            Assert.AreEqual("HAPPY", result);
        }
    }
}
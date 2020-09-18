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
            MoodAnalyserMain m = new MoodAnalyserMain("i am in sad mood");
            string result = m.getMood(); ;
            Assert.AreEqual("SAD", result);
        }

        [Test]
        public void WhenGivenHappyMessageShouldReturnHappy()
        {
            MoodAnalyserMain m = new MoodAnalyserMain("i am in any mood");
            string result = m.getMood();
            Assert.AreEqual("HAPPY", result);
        }
    }
}
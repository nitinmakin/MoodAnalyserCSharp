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
            MoodAnalyserMain m = new MoodAnalyserMain();
            string result = m.getMood("sad");
            Assert.AreEqual("SAD", result);
        }

        [Test]
        public void WhenGivenHappyMessageShouldReturnHappy()
        {
            MoodAnalyserMain m = new MoodAnalyserMain();
            string result = m.getMood("any");
            Assert.AreEqual("HAPPY", result);
        }
    }
}
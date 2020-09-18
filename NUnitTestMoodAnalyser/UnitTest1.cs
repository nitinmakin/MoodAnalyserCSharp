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
        public void Test1()
        {
            MoodAnalyserMain m = new MoodAnalyserMain();
            string result = m.getMood("sad");
            Assert.AreEqual("SAD", result);
        }
    }
}
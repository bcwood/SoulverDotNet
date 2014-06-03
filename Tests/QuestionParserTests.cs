using NUnit.Framework;
using SoulverDotNet.Core;

namespace SoulverDotNet.Tests
{
    [TestFixture]
    public class QuestionParserTests
    {
        [Test]
        public void Parse_MultiLine_LineVariable()
        {
            var questions = new string[]
            {
                "3 + 7", 
                "line1 * 2"
            };

            string[] answers = QuestionParser.Parse(questions);

            Assert.AreEqual("10", answers[0]);
            Assert.AreEqual("20", answers[1]);
        }

        [Test]
        public void Parse_MultiLine_MultiLineVariables()
        {
            var questions = new string[]
            {
                "3 + 7", 
                "line1 * 2",
                "(line1 + line2) / 2",
				"",
				"line3"
            };

            string[] answers = QuestionParser.Parse(questions);

            Assert.AreEqual("10", answers[0]);
            Assert.AreEqual("20", answers[1]);
            Assert.AreEqual("15", answers[2]);
			Assert.AreEqual("", answers[3]);
			Assert.AreEqual("15", answers[4]);
        }

        [Test]
        public void Parse_MultiLine_ValueVariable()
        {
            var questions = new string[]
            {
                "pi = 3.14", 
                "2 * pi"
            };

            string[] answers = QuestionParser.Parse(questions);

            Assert.AreEqual("6.28", answers[1]);
        }

        [Test]
        public void Parse_MultiLine_MultiValueVariables()
        {
            var questions = new string[]
            {
                "pi = 3.14", 
                "pi2 = 2 * pi",
                "pi + pi2"
            };

            string[] answers = QuestionParser.Parse(questions);

            Assert.AreEqual("9.42", answers[2]);
        }

		[Test]
		public void Parse_PercentOf()
		{
			var questions = new string[]
            {
                "25% of $100",
                "30% of 50",
				"12.5% of 25.5"
            };

			string[] answers = QuestionParser.Parse(questions);

			Assert.AreEqual((100 * 25 / 100).ToString(), answers[0]);
			Assert.AreEqual((50 * 30 / 100).ToString(), answers[1]);
			Assert.AreEqual((25.5 * 12.5 / 100).ToString(), answers[2]);
		}

		[Test]
		public void Parse_PercentOff()
		{
			var questions = new string[]
            {
				"25% off $100",
                "30% off 50",
				"12.5% off 25.5"
            };

			string[] answers = QuestionParser.Parse(questions);

			Assert.AreEqual((100 - (100 * 25 / 100)).ToString(), answers[0]);
			Assert.AreEqual((50 - (50 * 30 / 100)).ToString(), answers[1]);
			Assert.AreEqual((25.5 - (25.5 * 12.5 / 100)).ToString(), answers[2]);
		}
    }
}

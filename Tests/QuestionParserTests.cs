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

            Assert.That(answers[0], Is.EqualTo("10"));
			Assert.That(answers[1], Is.EqualTo("20"));
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

			Assert.That(answers[0], Is.EqualTo("10"));
			Assert.That(answers[1], Is.EqualTo("20"));
			Assert.That(answers[2], Is.EqualTo("15"));
			Assert.That(answers[3], Is.EqualTo(""));
			Assert.That(answers[4], Is.EqualTo("15"));
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

            Assert.That(answers[1], Is.EqualTo("6.28"));
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

            Assert.That(answers[2], Is.EqualTo("9.42"));
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

			Assert.That(answers[0], Is.EqualTo((100 * 25 / 100).ToString()));
			Assert.That(answers[1], Is.EqualTo((50 * 30 / 100).ToString()));
			Assert.That(answers[2], Is.EqualTo((25.5 * 12.5 / 100).ToString()));
		}

        [Test]
        public void Parse_PercentOf_Variable()
        {
			var questions = new string[]
			{
				"x = 25% of $100",
				"x"
			};

			string[] answers = QuestionParser.Parse(questions);

			Assert.That(answers[1], Is.EqualTo((100 * 25 / 100).ToString()));
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

			Assert.That(answers[0], Is.EqualTo((100 - (100 * 25 / 100)).ToString()));
			Assert.That(answers[1], Is.EqualTo((50 - (50 * 30 / 100)).ToString()));
			Assert.That(answers[2], Is.EqualTo((25.5 - (25.5 * 12.5 / 100)).ToString()));
		}

		[Test]
		public void Parse_PercentOff_Variable()
		{
			var questions = new string[]
			{
				"x = 25% off $100",
				"x"
			};

			string[] answers = QuestionParser.Parse(questions);

			Assert.That(answers[1], Is.EqualTo((100 - (100 * 25 / 100)).ToString()));
		}
	}
}

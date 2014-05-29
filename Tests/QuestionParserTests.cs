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
                "(line1 + line2) / 2"
            };

            string[] answers = QuestionParser.Parse(questions);

            Assert.AreEqual("10", answers[0]);
            Assert.AreEqual("20", answers[1]);
            Assert.AreEqual("15", answers[2]);
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
    }
}

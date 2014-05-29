using System;
using System.Text.RegularExpressions;

namespace SoulverDotNet.Parser
{
    public class LineVariable
    {
        private const string REGEX_PATTERN = "line([0-9]+)";

        public static bool IsMatch(string s)
        {
            if (!Regex.IsMatch(s, REGEX_PATTERN))
                return false;
            else
            {
                string expression = ParseExpression(s);

                if (!String.IsNullOrEmpty(expression))
                    return ExpressionCompiler.IsMatch(expression);
                else
                    return false;
            }
        }

        public static double? Parse(string s)
        {
            string expression = ParseExpression(s);

            if (!String.IsNullOrEmpty(expression))
            {
                if (!Regex.IsMatch(expression, REGEX_PATTERN))
                    return ExpressionCompiler.Parse(expression);
                else
                {
                    // if expression still matches regex, it means that one of the line variables
                    // could not be parsed (most likely because it doesn't exist)
                    return null;
                }
            }
            else
                return null;
        }

        private static string ParseExpression(string s)
        {
            // get line number
            int index = s.IndexOf("line") + 4;
            string substring = s.Substring(index);
            string[] parts = Regex.Split(substring, "\\D");
            int lineNumber = Int32.Parse(parts[0]);

            string answer = QuestionParser.GetAnswerAt(lineNumber - 1);
            if (String.IsNullOrEmpty(answer))
                return null;

            string lineVariable = "line" + lineNumber;
            string expression = s.Replace(lineVariable, answer);

            // make recursive call if there is more than one line variable in the expression
            if (IsMatch(expression))
                return ParseExpression(expression);
            else
                return expression;
        }
    }
}

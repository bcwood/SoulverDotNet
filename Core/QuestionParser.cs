using System.Collections.Generic;

namespace SoulverDotNet.Core
{
    public static class QuestionParser
    {
        private static List<string> _answers;

        public static string[] Parse(string[] questions)
        {
            ExpressionCompiler.Reset();
            _answers = new List<string>();

            foreach (string question in questions)
            {
                _answers.Add(Parse(question).ToString());
            }

            return _answers.ToArray();
        }

        internal static double? Parse(string question)
        {
            if (ValueVariable.IsMatch(question))
            {
                var variable = ValueVariable.Parse(question);
                ExpressionCompiler.AddVariable(variable.Key, variable.Value);
                return variable.Value;
            }
            else if (LineVariable.IsMatch(question))
            {
                return LineVariable.Parse(question);
            }
            else if (ExpressionCompiler.IsMatch(question))
            {
                return ExpressionCompiler.Parse(question);
            }
            else
            {
                return null;
            }
        }

        public static string GetAnswerAt(int index)
        {
            if (index >= _answers.Count)
                return null;

            return _answers[index];
        }
    }
}

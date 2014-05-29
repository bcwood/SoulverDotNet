using System;
using System.Text.RegularExpressions;

namespace SoulverDotNet.Core
{
    public class ValueVariable
    {
        private const string REGEX_PATTERN = "^[a-zA-Z0-9]+\\s*=.+$";

        public string Key { get; private set; }
        public double Value { get; private set; }

        public static bool IsMatch(string expression)
        {
            if (!Regex.IsMatch(expression, REGEX_PATTERN))
                return false;
	        
			int index = expression.IndexOf("=") + 1;
	        string parsedExpression = expression.Substring(index).Trim();

	        return MathExpression.IsMatch(parsedExpression);
        }

        public static ValueVariable Parse(string expression)
        {
            string[] parts = expression.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);

            var variable = new ValueVariable();
            variable.Key = parts[0].Trim();
            variable.Value = MathExpression.Parse(parts[1].Trim());

			return variable;
        }
    }
}

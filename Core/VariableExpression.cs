using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoulverDotNet.Core
{
    public static class VariableExpression
    {
        private const string REGEX_PATTERN = "^[a-zA-Z0-9]+\\s*=.+$";

        public static bool IsMatch(string expression)
        {
            if (!Regex.IsMatch(expression, REGEX_PATTERN))
                return false;
	        
			int index = expression.IndexOf("=") + 1;
	        string parsedExpression = expression.Substring(index).Trim();

	        return MathExpression.IsMatch(parsedExpression);
        }

		public static KeyValuePair<string, double> Parse(string expression)
        {
            string[] parts = expression.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);

			return new KeyValuePair<string, double>(parts[0].Trim(), MathExpression.Parse(parts[1].Trim()));
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace SoulverDotNet.Core
{
    public class ValueVariable
    {
        private const string REGEX_PATTERN = "^[a-zA-Z0-9]+\\s*=.+$";

        public string Key { get; private set; }
        public double Value { get; private set; }

        public static bool IsMatch(string s)
        {
            if (!Regex.IsMatch(s, REGEX_PATTERN))
                return false;
            else
            {
                int index = s.IndexOf("=") + 1;
                string expression = s.Substring(index).Trim();

                return ExpressionCompiler.IsMatch(expression);
            }
        }

        public static ValueVariable Parse(string s)
        {
            string[] parts = s.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);

            var v = new ValueVariable();
            v.Key = parts[0].Trim();
            v.Value = (double) ExpressionCompiler.Parse(parts[1].Trim());

            return v;
        }
    }
}

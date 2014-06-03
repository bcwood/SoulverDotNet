using System.Text.RegularExpressions;

namespace SoulverDotNet.Core
{
	public static class PercentOffExpression
	{
		private const string REGEX_PATTERN = @"^([0-9]+(.[0-9]+)?)%\soff\s\$?([0-9]+(.[0-9]+)?)$";

		public static bool IsMatch(string expression)
		{
			return Regex.IsMatch(expression, REGEX_PATTERN);
		}

		public static double Parse(string expression)
		{
			Match match = Regex.Match(expression, REGEX_PATTERN);

			double percent = double.Parse(match.Groups[1].Value);
			double value = double.Parse(match.Groups[3].Value);

			return value - (value * percent / 100);
		}
	}
}

using System;
using dotMath;

namespace SoulverDotNet.Core
{
    public static class MathExpression
    {
		private static EquationCompiler _compiler = new EquationCompiler();

		public static bool IsMatch(string expression)
        {
            try
            {
                _compiler.SetFunction(expression);
                _compiler.Compile();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

		public static double Parse(string expression)
        {
            _compiler.SetFunction(expression);
			return _compiler.Calculate();
        }

		public static void AddVariable(string key, double value)
		{
			_compiler.SetVariable(key, value);
		}

		public static void Reset()
        {
			_compiler = new EquationCompiler();
        }
    }
}

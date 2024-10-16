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
            catch
            {
                return false;
            }
        }

		public static double? Parse(string expression)
        {
            try
            {
                _compiler.SetFunction(expression);
                return _compiler.Calculate();
            }
            catch 
            {
                return null;
            }
        }

		public static void AddVariable(string key, double? value)
		{
            if (value != null)
			    _compiler.SetVariable(key, value.Value);
		}

		public static void Reset()
        {
			_compiler = new EquationCompiler();
        }
    }
}

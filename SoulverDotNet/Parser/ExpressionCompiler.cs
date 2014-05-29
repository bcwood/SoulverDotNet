using System;
using dotMath;

namespace SoulverDotNet.Parser
{
    public static class ExpressionCompiler
    {
        private static EquationCompiler compiler;

        public static void AddVariable(string key, double value)
        {
            InitializeCompiler();

            compiler.SetVariable(key, value);
        }
        
        public static bool IsMatch(string s)
        {
            InitializeCompiler();

            try
            {
                compiler.SetFunction(s);
                compiler.Compile();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static double? Parse(string s)
        {
            InitializeCompiler();

            compiler.SetFunction(s);

            try
            {
                return compiler.Calculate();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void Reset()
        {
			compiler = new EquationCompiler();
        }

        private static void InitializeCompiler()
        {
            if (compiler == null)
				compiler = new EquationCompiler();
        }
    }
}

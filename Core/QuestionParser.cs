﻿using System.Collections.Generic;

namespace SoulverDotNet.Core
{
    public static class QuestionParser
    {
        public static string[] Parse(string[] questions)
        {
            MathExpression.Reset();
	        var answers = new string[questions.Length];

	        for (int i = 0; i < questions.Length; i++)
	        {
		        double? answer = Parse(questions[i]);
				answers[i] = answer.ToString();

				if (answer != null)
					MathExpression.AddVariable("line" + (i + 1), answer.Value);
	        }

	        return answers;
        }

	    private static double? Parse(string question)
        {
            if (VariableExpression.IsMatch(question))
            {
                KeyValuePair<string, double> variable = VariableExpression.Parse(question);
                MathExpression.AddVariable(variable.Key, variable.Value);
                return variable.Value;
            }
            else if (MathExpression.IsMatch(question))
            {
                return MathExpression.Parse(question);
            }
            else
            {
                return null;
            }
        }
    }
}

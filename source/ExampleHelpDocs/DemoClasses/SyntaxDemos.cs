using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleHelpDocs
{
	public static class SyntaxDemos
	{
		internal static int IfExample()
		{

			#region If-Example
			int distance = 8000;
			if (distance > 5000)
			{
				Console.WriteLine("A long trip");
			}
			#endregion

			return 0;
		}

		internal static int IfElseExample()
		{

			#region IfElse-Example
			int distance = 1200;
			if (distance > 5000)
			{
				Console.WriteLine("A long trip");
			}
			else
			{
				Console.WriteLine("A short trip");
			}


			#endregion

			return 0;
		}

		internal static int SwitchExpressionExample()
		{

			#region SwitchExpression-Example
			var number = 10;
			var resultText = string.Empty;

			resultText = number switch
			{
				0 => "Zero",
				1 => "One",
				-1 => "Negative One",
				int x when ( Math.Abs(x) % 2 == 0) => "Even Number",
				int x when (Math.Abs(x) % 2 == 1) => "Odd Number",
				_ => "unknown",
			};

		
			Console.WriteLine($"{number} is {resultText}");
			#endregion

			return 0;
		}
	}
}

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
			int distance = 8000;
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

		#endregion

		return 0;
	}
}
}

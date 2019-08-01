using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleHelpDocs
{
	public static class LinqDemos
	{

		internal static int LinqExample1()
		{
			// code outside the region is run, but is not shown in editor

			var numbers = new List<int> { 3, 5, 7, 9, 2, 4, 6, 8, 20, 40, 90, 100, };

			#region LinqProjection-Example

			var q = from n in numbers
							select (n * n);

			foreach (var number in numbers)
			{
				Console.WriteLine($"{number},");
			}
			Console.WriteLine();
			foreach (var number in q)
			{
				Console.Write($"{number},");
			}

			#endregion
			return 0;
		}
		internal static int LinqExample2()
		{
			#region LinqTransform-Example
			// use a list to index items from another list.
			var preferredOrder = new List<int> { 5, 4, 1, 3, 2, 0 };

			var foodNames = new List<string> { "apple", "banana", "cherry", "durian", "eggplant", "fig"};
		

			var q = from preferredIndex in preferredOrder
							select new { Position = preferredIndex, Word = foodNames[preferredIndex] };

			foreach (var item in q)
			{
				Console.WriteLine($"Position: {item.Position}, Word: {item.Word}");
			}
			#endregion
			return 0;
		}
	}
}

using System;
using System.Threading.Tasks;

namespace ExampleHelpDocs
{
    ///<summary>This program uses <a href="https://github.com/dotnet/command-line-api/wiki/DragonFruit-overview">System.CommandLine.DragonFruit</a> to accept command line arguments from command line.
    ///<example>Execute: dotnet run --region "HelloWorld" to see the output</example>
    ///</summary>
    public class Program
    {
        ///<param name="region">Takes in the --region option from the code fence options in markdown</param>
        ///<param name="session">Takes in the --session option from the code fence options in markdown</param>
        ///<param name="package">Takes in the --package option from the code fence options in markdown</param>
        ///<param name="project">Takes in the --project option from the code fence options in markdown</param>
        ///<param name="args">Takes in any additional arguments passed in the code fence options in markdown</param>
        ///<see>To learn more see <a href="https://aka.ms/learntdn">our documentation</a></see>
        static int Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
	
            return region switch
            {
							"If-Example" => SyntaxDemos.IfExample(),
              "IfElse-Example" => SyntaxDemos.IfElseExample(),
							"SwitchExpression-Example" => SyntaxDemos.SwitchExpressionExample(),
							"LinqProjection-Example" => LinqDemos.LinqExample1(),
							"LinqTransform-Example" => LinqDemos.LinqExample2(),
							_ => throw new ArgumentException("A --region argument must be passed", nameof(region))
            };
        }

   


    }
}
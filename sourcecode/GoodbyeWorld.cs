using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.Sample02.Steps333
{
    public class GoodbyeWorld : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
        	//GOOD BY 696
            Console.WriteLine("Goodbye world");
            return ExecutionResult.Next();
        }
    }
}

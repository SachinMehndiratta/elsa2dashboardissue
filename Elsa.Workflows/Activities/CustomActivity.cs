using Elsa;
using Elsa.ActivityResults;
using Elsa.Attributes;
using Elsa.Expressions;
using Elsa.Services;
using Elsa.Services.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ElsaTest.Workflows.Activities
{
    [Action(Category = "ElsaTest", Description = "Custom", Outcomes = new[] { OutcomeNames.Done, "Failed" })]

    public class CustomActivity : Activity
    {
       
        public CustomActivity(
            
          )
        {
         
        }


        [ActivityProperty(Hint = "Enter an expression", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public string FilePath { get; set; } = default!;

        protected override async ValueTask<IActivityExecutionResult> OnExecuteAsync(ActivityExecutionContext context)
        {
            return Done();
        }
    }
}

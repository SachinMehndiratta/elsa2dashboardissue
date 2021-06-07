using Elsa;
using Elsa.ActivityResults;
using Elsa.Attributes;
using Elsa.Expressions;
using Elsa.Services;
using Elsa.Services.Models;
using System;
using System.Threading.Tasks;


namespace ElsaTest.Workflows.Activities
{
    [Activity(Category = "ElsaTest", Description = "Download content from FTP", Outcomes = new[] {  OutcomeNames.Done, "Failed"})]
    public class FTPActivity : Activity
    {
       
     

        public FTPActivity(
          
          )
        {
         
        }

        [ActivityProperty(Hint = "Enter an expression that evaluates to the name of the host to connect.", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public string ServerName { get; set; } = default!;

        [ActivityProperty(Hint = "Enter an expression that evaluates to the username to connect.", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public string UserName { get; set; } = default!;

        [ActivityProperty(Hint = "Enter an expression that evaluates to the password to connect.", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public string Password { get; set; } = default!;


        [ActivityProperty(Hint = "Enter an expression that evaluates to the port to connect.", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public int PortNumber { get; set; } = default!;

        [ActivityProperty(Hint = "Enter an expression that evaluates to the path on the remote.", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public string RemotePath { get; set; } = default!;

        [ActivityProperty(Hint = "Enter an expression that evaluates to the directory name on the remote.", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public string DirectoryName { get; set; } = default!;

        [ActivityProperty(Hint = "Enter an expression that evaluates to the local path to save content.", SupportedSyntaxes = new[] { SyntaxNames.JavaScript, SyntaxNames.Liquid })]
        public string LocalTargetPath { get; set; } = default!;

      

        protected override async ValueTask<IActivityExecutionResult> OnExecuteAsync(ActivityExecutionContext context)
        {
            try
            {

             

                // Create audit log
               // Output.SetVariable("Content", LocalTargetPath);
                return Done();
            }
            catch (Exception e)
            {

              
               // Output.SetVariable("Content", LocalTargetPath);
                return Outcome("Failed"); 
            }

        }
    }
}

using Elsa.Scripting.Liquid.Messages;
using Fluid;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ElsaTest.Workflows.Handlers
{
    public class LiquidConfigurationHandler : INotificationHandler<EvaluatingLiquidExpression>
    {
        public Task Handle(EvaluatingLiquidExpression notification, CancellationToken cancellationToken)
        {
            var context = notification.TemplateContext;
            var options = context.Options;
            options.MemberAccessStrategy.Register<ExtractionObjectModel>();
          
            return Task.CompletedTask;
        }
    }
}

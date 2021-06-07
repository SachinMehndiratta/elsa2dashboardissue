using Elsa;
using Elsa.Persistence.EntityFramework.Core;
using Elsa.Persistence.EntityFramework.Core.Extensions;
using ElsaTest.Workflows.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ElsaTest.Workflows
{

    public static class ElsaTestWorkflowBuilderExtensions
    {
      

        public static void ConfigureElsaTestWorkflows(this IServiceCollection services, IConfiguration configuration)

        {
           // services.AddDbContext<WorkflowContext>();
            services
            .AddElsa(elsa => elsa
            .UseEntityFrameworkPersistence<ElsaContext>(ef => ef.UseSqlServer("Server=;Database=ElsaWorkflow;UID=;PWD=;MultipleActiveResultSets=True;", builder =>
                {
                    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(5), null);
                  //  builder.MigrationsAssembly("Elsa.Dashboard");

                }))

                .AddConsoleActivities()
             
               .AddQuartzTemporalActivities()
            
                .AddTestActivities()
                
                   );


        }


    }
}

using Elsa;
using ElsaTest.Workflows.Activities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElsaTest.Workflows.Extensions
{
    public static class TestCollection
    {
        public static ElsaOptionsBuilder AddTestActivities(this ElsaOptionsBuilder services)
        {
            return services
                .AddActivity<FTPActivity>()
             .AddActivity<CustomActivity>();

        }
    }
}

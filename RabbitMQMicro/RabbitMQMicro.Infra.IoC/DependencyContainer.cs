using Microsoft.Extensions.DependencyInjection;
using RabbitMQMicro.Domain.Core.Bus;
using RabbitMQMicro.Infra.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQMicro.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) 
        {
            //Domain bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}

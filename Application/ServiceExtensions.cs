using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            //Registra automaticamente los mapeos que haga en esta biblioteca de clase
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            //FluentValidation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            //MediatR
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}

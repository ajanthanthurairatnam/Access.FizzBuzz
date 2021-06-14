using Access.FizzBuzz.Application.Rules;
using Microsoft.Extensions.DependencyInjection;

namespace Access.FizzBuzz.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IRule, FizzBuzzRule>();
            services.AddTransient<IRule, FizzRule>();
            services.AddTransient<IRule, BuzzRule>();
            services.AddTransient<IRule, NotDividedByAnyGivenNumbersRule>();
            services.AddTransient<IGameEngine, GameEngine>();
            return services;
        }
    }
}

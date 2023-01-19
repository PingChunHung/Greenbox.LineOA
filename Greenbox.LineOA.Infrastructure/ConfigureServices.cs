using Greenbox.LineOA.Application.Common.Interfaces;
using Greenbox.LineOA.Infrastructure.Services.LineBot;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace Greenbox.LineOA.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<ILinkingUserAccountsService, LinkingUserAccountsService>();
            services.AddTransient<IJsonConverter, Services.LineBot.JsonConverter>();
            return services;
        }
    }
}
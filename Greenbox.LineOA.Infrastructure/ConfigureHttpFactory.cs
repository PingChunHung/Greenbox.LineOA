using Greenbox.LineOA.Infrastructure.Log;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Infrastructure
{
    public static class ConfigureHttpFactory
    {
        public static void ConfigureLineBotHttpClient(this IServiceCollection services, ConfigurationManager configuration)
        {
            string token = configuration.GetValue<string>("LineOption:ChannelAccessToken");
            services.AddHttpClient("LineBotMessageApi", client =>
            {
                client.BaseAddress = new Uri("https://api.line.me/v2/bot/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            });
        }
    }
}

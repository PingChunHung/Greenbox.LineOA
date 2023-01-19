using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Infrastructure.Log
{
    public static class ConfigureLogProvider
    {
        public static void ConfigureLog(this WebApplicationBuilder builder)
        {
            builder.Logging.ClearProviders();
            builder.Host.UseNLog();
            builder.Services.AddSingleton<ILogHelper, NLogHelper>();
        }
    }
}
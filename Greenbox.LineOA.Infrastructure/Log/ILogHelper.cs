using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Infrastructure.Log
{
    public interface ILogHelper
    {
        void Info(string message, LogEvent logEvent);
        void Error(string message, LogEvent logEvent, Exception exception);
    }
}

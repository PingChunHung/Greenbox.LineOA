using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Infrastructure.Log
{
    public enum LogEvent
    {
        None = 0,
        LineBot = 1
    }

    public enum LogLevel
    {
        Info, Error
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Application.Common.Interfaces
{
    public interface IJsonConverter
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string str);
    }
}

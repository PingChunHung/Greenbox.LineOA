using Greenbox.LineOA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Message
{
    public class BroadcastMessage<T> where T : BaseMessage
    {
        public List<T> Messages { get; init; }
        public bool? NotificationDisabled { get; init; }
    }
}

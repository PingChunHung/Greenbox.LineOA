using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Entities.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Application.Common.Interfaces.LineBot
{
    public interface IMessageService
    {
        Task Reply<T>(ReplyMessage<T> replyMessage) where T : BaseMessage;
        Task Push<T>(PushMessage<T> pushMessage) where T : BaseMessage;
        Task SendMulticastMessage<T>(MulticastMessage<T> multicastMessage) where T : BaseMessage;
        Task SendBroadcastMessage<T>(BroadcastMessage<T> broadcastMessage) where T : BaseMessage;
    }
}

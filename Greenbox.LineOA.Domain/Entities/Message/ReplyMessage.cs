using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greenbox.LineOA.Domain.Common;

namespace Greenbox.LineOA.Domain.Entities.Message
{
    public class ReplyMessage<T> where T : BaseMessage
    {
        public ReplyMessage(string replyToken, List<T> messages) 
        { 
            ReplyToken= replyToken;
            Messages = messages;
        }

        public string ReplyToken { get; init; }
        public List<T> Messages { get; init; }
    }
}

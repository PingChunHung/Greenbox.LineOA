using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Message.MessageObject
{
    public class TextMessage : BaseMessage
    {
        public TextMessage(string text)
        {
            Type = MessageTypeEnum.Text;
            Text = text;
        }

        public string? Text { get; init; }
        public List<TextMessageEmojiDto>? Emojis { get; set; }
    }

    public class TextMessageEmojiDto
    {
        public int Index { get; set; }
        public string? ProductId { get; set; }
        public string? EmojiId { get; set; }
    }
}

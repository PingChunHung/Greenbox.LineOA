using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Enums;

namespace Greenbox.LineOA.Domain.Entities.Message.MessageObject
{
    public class AudioMessage : BaseMessage
    {
        public AudioMessage()
        {
            Type = MessageTypeEnum.Audio;
        }

        public string? OriginalContentUrl { get; set; }
        public int Duration { get; set; }
    }
}

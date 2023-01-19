using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Message.MessageObject
{
    public class StickerMessage : BaseMessage
    {
        public StickerMessage()
        {
            Type = MessageTypeEnum.Sticker;
        }

        public string? PackageId { get; set; }

        public string? StickerId { get; set; }
    }
}

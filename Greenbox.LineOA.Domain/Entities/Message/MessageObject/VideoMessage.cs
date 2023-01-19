using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Message.MessageObject
{
    public class VideoMessage : BaseMessage
    {
        public VideoMessage()
        {
            Type = MessageTypeEnum.Video;
        }

        public string? OriginalContentUrl { get; set; }

        public string? PreviewImageUrl { get; set; }

        public string? TrackingId { get; set; }
    }
}

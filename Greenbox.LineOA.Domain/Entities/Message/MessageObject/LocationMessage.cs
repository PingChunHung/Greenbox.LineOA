using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Message.MessageObject
{
    public class LocationMessage
    {
        public class LocationMessageDto : BaseMessage
        {
            public LocationMessageDto()
            {
                Type = MessageTypeEnum.Location;
            }

            public string? Title { get; set; }
            public string? Address { get; set; }

            public double Latitude { get; set; } // 緯度
            public double Longitude { get; set; } // 經度
        }
    }
}

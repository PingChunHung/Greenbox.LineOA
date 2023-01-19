using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Message.MessageObject
{
    public class ImagemapAction
    {
        public string? Type { get; set; }
        public string? Label { get; set; }

        // Message action
        public string? Text { get; set; }

        // Uri action
        public string? LinkUri { get; set; }

        public ImagemapArea? Area { get; set; }
    }
}

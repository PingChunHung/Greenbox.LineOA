using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Enums;

namespace Greenbox.LineOA.Domain.Entities.Message.MessageObject
{
    public class ImagemapMessage : BaseMessage
    {
        public ImagemapMessage()
        {
            Type = MessageTypeEnum.Imagemap;
        }

        public string BaseUrl { get; set; }
        public string AltText { get; set; }
        public ImagemapBaseSizeDto BaseSize { get; set; }
        public ImagemapVideoDto? Video { get; set; }

        public List<ImagemapAction> Actions { get; set; }
    }

    public class ImagemapBaseSizeDto
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class ImagemapVideoDto
    {
        public string OriginalContentUrl { get; set; }
        public string PreviewImageUrl { get; set; }
        public ImagemapArea Area { get; set; }
        public ImagemapVideoExternalLink ExternalLink { get; set; }
    }

    public class ImagemapArea
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class ImagemapVideoExternalLink
    {
        public string LinkUri { get; set; }
        public string Label { get; set; }
    }
}

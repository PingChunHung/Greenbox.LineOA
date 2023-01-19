using Greenbox.LineOA.Application.Common.Mappings;
using Greenbox.LineOA.Domain.Entities.Users;

namespace Greenbox.LineOA.Application.Users.Queries
{
    public class UserProfileDto : IMapFrom<UserProfile>
    {
        public string? UserId { get; set; }
        public string? DisplayName { get; set; }
        public string? PictureUrl { get; set; }
        public string? StatusMessage { get; set; }
        public string? Language { get; set; }
    }
}

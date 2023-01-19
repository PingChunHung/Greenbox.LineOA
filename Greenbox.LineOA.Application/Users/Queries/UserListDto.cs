using Greenbox.LineOA.Application.Common.Mappings;
using Greenbox.LineOA.Domain.Entities.Users;

namespace Greenbox.LineOA.Application.Users.Queries
{
    public class UserListDto : IMapFrom<UserList>
    {
        public List<string>? UserIds { get; set; }
        public string? Next { get; set; }
    }
}

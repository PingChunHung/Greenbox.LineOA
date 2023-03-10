using Greenbox.LineOA.Domain.Entities.Users;

namespace Greenbox.LineOA.Application.Common.Interfaces.LineBot
{
    public interface IUserService
    {
        Task<UserProfile> GetUserProfile(string userId);
        Task<UserList> GetLineOAFriendUserList(int? limit, string? start);
    }
}

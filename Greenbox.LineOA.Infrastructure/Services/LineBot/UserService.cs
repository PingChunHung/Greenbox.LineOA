using Greenbox.LineOA.Application.Common.Interfaces.LineBot;
using Greenbox.LineOA.Domain.Entities.Users;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Greenbox.LineOA.Infrastructure.Services.LineBot
{
    public class UserService : IUserService
    {
        private readonly HttpClient _LineBotMessageApiClient;

        public UserService(IHttpClientFactory httpClientFactory)
        {
            _LineBotMessageApiClient = httpClientFactory.CreateClient("LineBotMessageApi");
        }

        public async Task<UserProfile> GetUserProfile(string userId)
        {
            var httpResponseMessage = await _LineBotMessageApiClient.GetAsync($"profile/{userId}");
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new BadHttpRequestException($"{nameof(GetUserProfile)}請求失敗");

            string result = await httpResponseMessage.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UserProfile>(result);
        }

        public async Task<UserList> GetLineOAFriendUserList(int? limit, string? start)
        {
            var httpResponseMessage = await _LineBotMessageApiClient.GetAsync($"followers/ids");
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new BadHttpRequestException($"{nameof(GetUserProfile)}請求失敗");

            string result = await httpResponseMessage.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UserList>(result);
        }
    }
}

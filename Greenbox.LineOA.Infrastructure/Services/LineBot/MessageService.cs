using Greenbox.LineOA.Application.Common.Interfaces.LineBot;
using Greenbox.LineOA.Domain.Common;
using Greenbox.LineOA.Domain.Entities.Message;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

namespace Greenbox.LineOA.Infrastructure.Services.LineBot
{
    public class MessageService : IMessageService
    {
        private readonly HttpClient _LineBotMessageApiClient;
        private readonly IJsonConverter _jsonConverter;

        public MessageService(IHttpClientFactory httpClientFactory, IJsonConverter jsonConverter)
        {
            _LineBotMessageApiClient = httpClientFactory.CreateClient("LineBotMessageApi");
            _jsonConverter = jsonConverter;
        }

        public async Task Push<T>(PushMessage<T> pushMessage) where T : BaseMessage
        {
            var json = _jsonConverter.Serialize(pushMessage);
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var httpResponseMessage = await _LineBotMessageApiClient.PostAsync("message/push", httpContent);
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new BadHttpRequestException($"{nameof(Push)}請求失敗{httpResponseMessage.StatusCode}");
        }

        public async Task Reply<T>(ReplyMessage<T> replyMessage) where T : BaseMessage
        {
            var json = _jsonConverter.Serialize(replyMessage);
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var httpResponseMessage = await _LineBotMessageApiClient.PostAsync("message/reply", httpContent);
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new BadHttpRequestException($"{nameof(Push)}請求失敗{httpResponseMessage.StatusCode}");
        }

        public async Task SendBroadcastMessage<T>(BroadcastMessage<T> broadcastMessage) where T : BaseMessage
        {
            var json = _jsonConverter.Serialize(broadcastMessage);
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var httpResponseMessage = await _LineBotMessageApiClient.PostAsync("message/broadcast", httpContent);
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new BadHttpRequestException($"{nameof(Push)}請求失敗{httpResponseMessage.StatusCode}");
        }

        public async Task SendMulticastMessage<T>(MulticastMessage<T> multicastMessage) where T : BaseMessage
        {
            var json = _jsonConverter.Serialize(multicastMessage);
            HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var httpResponseMessage = await _LineBotMessageApiClient.PostAsync("message/multicast", httpContent);
            if (!httpResponseMessage.IsSuccessStatusCode)
                throw new BadHttpRequestException($"{nameof(Push)}請求失敗{httpResponseMessage.StatusCode}");
        }
    }
}

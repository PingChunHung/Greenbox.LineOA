using Greenbox.LineOA.Application.Common.Interfaces.LineBot;
using Greenbox.LineOA.Application.Webhook.Dtos;
using Greenbox.LineOA.Domain.Entities.Message;
using Greenbox.LineOA.Domain.Entities.Message.MessageObject;
using Greenbox.LineOA.Infrastructure.Log;
using Microsoft.AspNetCore.Mvc;

namespace Greenbox.LineOA.Controllers
{
    public class WebhookController : ApiControllerBase
    {
        private readonly ILogHelper _logger;
        private readonly IMessageService _messageService;

        public WebhookController(ILogHelper logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        [HttpPost]
        public async Task<IActionResult> Webhook(WebhookRequestBodyDto request)
        {
            //2022/01/19測試代碼
            List<TextMessage> textMessages = new List<TextMessage> { new TextMessage("你好") };
            ReplyMessage<TextMessage> replyMessage = new ReplyMessage<TextMessage>(request.Events.FirstOrDefault().ReplyToken, textMessages);
            await _messageService.Reply(replyMessage);
            return Ok();
        }
    }
}

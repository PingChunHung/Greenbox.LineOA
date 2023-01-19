using Greenbox.LineOA.Application.Common.Interfaces.LineBot;
using Greenbox.LineOA.Infrastructure.Log;
using Microsoft.AspNetCore.Mvc;

namespace Greenbox.LineOA.Controllers
{
    public class MessageController : ApiControllerBase
    {
        private readonly ILogHelper _logger;
        private readonly IMessageService _messageService;

        public MessageController(ILogHelper logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        /// <summary>
        /// 回覆訊息，一分鐘內需要回覆，免費
        /// </summary>
        /// <returns></returns>
        [HttpPost("reply")]
        public IActionResult Reply()
        {
            return Ok();
        }

        /// <summary>
        /// 推播訊息給一位使用者
        /// </summary>
        /// <returns></returns>
        [HttpPost("push")]
        public IActionResult Push()
        {
            return Ok();
        }

        /// <summary>
        /// 根據一個 UserID 清單推播訊息給多位使用者
        /// </summary>
        /// <returns></returns>
        [HttpPost("multicast")]
        public IActionResult Multicast()
        {
            return Ok();
        }

        /// <summary>
        /// 推播訊息給特定標籤或預設好的受眾
        /// </summary>
        /// <returns></returns>
        [HttpPost("narrowcast")]
        public IActionResult Narrowcast()
        {
            return Ok();
        }

        /// <summary>
        /// 推播訊息給 Line bot 的所有好友
        /// </summary>
        /// <returns></returns>
        [HttpPost("broadcast")]
        public IActionResult Broadcast()
        {
            return Ok();
        }
    }
}

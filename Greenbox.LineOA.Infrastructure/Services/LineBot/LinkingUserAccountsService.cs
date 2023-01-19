using Greenbox.LineOA.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Infrastructure.Services.LineBot
{
    public class LinkingUserAccountsService : ILinkingUserAccountsService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LinkingUserAccountsService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public string IssueTheLinkToken(string userId)
        {
            throw new NotImplementedException();
        }
    }
}

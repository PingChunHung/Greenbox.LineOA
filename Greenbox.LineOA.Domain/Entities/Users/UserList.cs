using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Users
{
    public class UserList
    {
        public List<string>? UserIds { get; set; }
        public string? Next { get; set; }
    }
}

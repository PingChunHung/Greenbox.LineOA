﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenbox.LineOA.Domain.Entities.Users
{
    public class UserProfile
    {
        public string? UserId { get; set; }
        public string? DisplayName { get; set; }
        public string? PictureUrl { get; set; }
        public string? StatusMessage { get; set; }
        public string? Language { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterCard.SDK.Services.Common.Domain
{
    public class RequestTokenResponse
    {
        public string RequestToken { get; set; }
        public string AuthorizeUrl { get; set; }
        public bool CallbackConfirmed { get; set; }
        public string OAuthExpiresIn { get; set; }
        public string OAuthSecret { get; set; }
    }
}

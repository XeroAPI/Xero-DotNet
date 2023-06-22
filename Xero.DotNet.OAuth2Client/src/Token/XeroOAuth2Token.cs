using System;
using System.Collections.Generic;
using Xero.DotNet.OAuth2.Models;

namespace Xero.DotNet.OAuth2.Token
{
    public class XeroOAuth2Token : IXeroToken
    {
        public List<Tenant> Tenants { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string IdToken { get; set; }
        public DateTime ExpiresAtUtc { get; set; }

    }
}
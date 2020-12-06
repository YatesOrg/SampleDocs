using System;
using System.Collections.Generic;
using System.Text;

namespace DevNet.Online
{
    /// <summary>
    /// An application user and OpenID Connect credentials.
    /// </summary>
    public class ApplicationUser
    {
        /// <summary>
        /// The OpenID tokens for communicating with an online tenant.
        /// </summary>
        public OAuthTokens AuthTokens { get; set; }
    }
}

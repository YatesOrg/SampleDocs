using System;
using System.Collections.Generic;
using System.Text;

namespace DevNet.Online
{
    /// <summary>
    /// OAuth and OpenID Connect tokens.
    /// </summary>
    public class OAuthTokens
    {
        /// <summary>
        /// OAuth bearer access_token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// OpenID Connect identity token.
        /// </summary>
        public string IdToken { get; set; }

        /// <summary>
        /// OAuth refresh token, used to obtain a new access_token.
        /// </summary>
        public string RefreshToken { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevNet.Online
{
    /// <summary>
    /// Registered online application.
    /// </summary>
    public class Application
    {
        /// <summary>
        /// The application ID value.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The application name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The application client identifier, or application id.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// The application secret token, or application token.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// The application private RSAXML string. Used for signing system user requests.
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// The application redirect URI. 
        /// </summary>
        public Uri RedirectUri { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevNet.Online
{
    /// <summary>
    /// The authorization between an online tenant and application.
    /// </summary>
    public class ApplicationAuthorization
    {
        /// <summary>
        /// The authorization ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The system user token used during the exchange to obtain a system user ticket.
        /// </summary>
        public string SystemUserToken { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DevNet.Online
{
    /// <summary>
    /// The application context contains all details for an application to tenant connection.
    /// </summary>
    public class ApplicationContext
    {
        /// <summary>
        /// Registered online application.
        /// </summary>
        public Application Application { get; set; }

        /// <summary>
        /// An application user and OpenID Connect credentials.
        /// </summary>
        public ApplicationUser ApplicationUser { get; set; }
        
        /// <summary>
        /// An online tenant, or customer, with environmental properties.
        /// </summary>
        public Tenant Tenant { get; set; }

    }
}

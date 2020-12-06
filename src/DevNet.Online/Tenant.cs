using System;

namespace DevNet.Online
{
    /// <summary>
    /// An online tenant, or customer, with environmental properties.
    /// </summary>
    public class Tenant
    {
        /// <summary>
        /// A tenant ID value.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The authorization between an online tenant and application.
        /// </summary>
        public ApplicationAuthorization ApplicationAuthorization { get; set; }

        /// <summary>
        /// The customer identification number.
        /// </summary>
        public string ContextIdentifier { get; set; }

        /// <summary>
        /// The online environment: Development, Stage or Production, and relevant URLs.
        /// </summary>
        public SuperOfficeEnvironment Environment { get; set; }

        /// <summary>
        /// The URL for online applications connecting to this tenants REST API.
        /// </summary>
        public string WebApiUrl => $"{Environment.ClaimsIssuer}/{ContextIdentifier}/api/";

        /// <summary>
        /// Tenant constructor.
        /// </summary>
        /// <param name="contextIdentifer">The customer identifier.</param>
        /// <param name="environment">The online environment where the customer tenant resides.</param>
        public Tenant(string contextIdentifer, SuperOfficeEnvironment environment)
        {
            ContextIdentifier = contextIdentifer;
            Environment = environment;
        }
    }
}

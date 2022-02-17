using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UPC.E31A.APIBusiness.API.Security
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// 
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string token_type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int expires_in { get; set; }
    }
}

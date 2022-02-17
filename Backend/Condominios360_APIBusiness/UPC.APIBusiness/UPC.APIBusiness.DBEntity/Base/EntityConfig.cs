using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBEntity
{

    /// <summary>
    /// Clase para datos de configuracion
    /// Author: James Huiza
    /// Date: 4 de Noviembre 2020
    /// </summary>
    public class ConfigSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ApplicationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OrganizationName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string Version { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string ApplicationDescription { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string UrlBaseIdentityServer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LDAP_Server { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PathUpload { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string PathImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PathTemplates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PathDocuments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PathDocGenerate { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string PathLog { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public CircuitBreak CircuitBreak { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public EmailConfiguration EmailConfiguration { get; set; }


        public Documents Documents { get; set; }
    }


    /// <summary>
    /// 
    /// </summary>
    public class Documents
    {
        /// <summary>
        /// 
        /// </summary>
        public string DocumentTrasuPASEonSin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DocumentTrasuPASEonCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_TRASU_EOSin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_TRASU_EOCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_RESEO_EOSin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_RESEO_EOCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_SAR_EOSin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_SAR_EOCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_SARA_EOSin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_SARA_EOCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_SAP_EOSin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DAPU_SAP_EOCon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string STSR_TRASU { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string STSR_RES_EO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string STSR_SAR { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string STSR_SARA { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string STSR_SAP { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// </summary>
    public class EmailConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        public string UrlBaseEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PortBaseEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EmailBase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PasswordEmailBase { get; set; }
    }


    /// <summary>
    /// CircuitBreaker
    /// </summary>
    public class CircuitBreak
    {
        /// <summary>
        /// 
        /// </summary>
        public string HandledEventsAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DurationOfBreakCircuit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RetryCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SleepDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string HandlerLifetime { get; set; }

    }
}

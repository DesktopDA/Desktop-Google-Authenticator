using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    /// <summary>
    /// AppSettingsProvider
    /// </summary>
    public static class AppSettingsProvider
    {
        /// <summary>
        /// config
        /// </summary>
        public static DBEntity.ConfigSettings config { get; set; }
    }

    /// <summary>
    /// Clase para datos de configuracion
    /// Author: James Huiza
    /// Date: 01 Enero 2021
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
        public CircuitBreak CircuitBreak { get; set; }
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

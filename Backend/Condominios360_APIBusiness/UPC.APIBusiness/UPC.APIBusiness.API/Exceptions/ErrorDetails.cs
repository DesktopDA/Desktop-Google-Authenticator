using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    /// <summary>
    /// Clase para el detalle de los errores en el Middleware
    /// Author: James Huiza
    /// Date: 01 Enero 2021
    /// </summary>
    public class CustomErrorException
    {
        /// <summary>
        /// Status de la llamada
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Mensaje de error
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///  Detalles
        /// </summary>
        public Detail Details { get; set; }

        /// <summary>
        ///  Tipo de Error
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///  Instancia
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// Override para serializar la clase
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    /// <summary>
    /// Detalle Técnico de Error
    /// </summary>
    public class Detail
    {
        /// <summary>
        ///  Tipo de Stack
        /// </summary>
        public string Stack { get; set; }

        /// <summary>
        ///  Tipo de Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///  Tipo de Object
        /// </summary>
        public string Object { get; set; }


    }
}

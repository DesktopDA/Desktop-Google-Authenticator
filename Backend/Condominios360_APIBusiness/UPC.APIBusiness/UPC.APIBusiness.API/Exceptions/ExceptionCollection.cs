using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    class NotFoundException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public NotFoundException() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        public NotFoundException(string detail)
            : base(String.Format("No se ha encontrado el recurso: {0}", detail))
        {

        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    class UnauthorizedException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public UnauthorizedException() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        public UnauthorizedException(string detail)
            : base(String.Format("Recurso no accesible por seguridad: {0}", detail))
        {

        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    class BadRequestException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public BadRequestException() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="detail"></param>
        public BadRequestException(string detail)
            : base(String.Format("Excepcion de servidor: {0}", detail))
        {

        }
    }
}

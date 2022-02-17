using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace API
{
    /// <summary>
    /// ErrorHandlingMiddleware
    /// </summary>
    public class ErrorHandlingMiddleware : ExceptionFilterAttribute
    {
        private readonly RequestDelegate next;

        /// <summary>
        /// ErrorHandlingMiddleware constructor
        /// </summary>
        /// <param name="next"></param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        /// <summary>
        /// Task Invoke
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// HandleExceptionAsync
        /// </summary>
        /// <param name="context"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            int code = (int)HttpStatusCode.InternalServerError;

            if (ex is NotFoundException) code = (int)HttpStatusCode.NotFound;
            else if (ex is UnauthorizedException) code = (int)HttpStatusCode.Unauthorized;
            else if (ex is BadRequestException) code = (int)HttpStatusCode.BadRequest;

            var result = JsonConvert.SerializeObject(
                new CustomErrorException()
                {
                    StatusCode = code,
                    Message = ex.Message,
                    Details = new Detail()
                    {
                        Code = ex.HResult.ToString(),
                        Stack = ex.StackTrace,
                        Object = ex.GetType().ToString()
                    }
                });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}

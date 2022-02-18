using DBContext;
using DBEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSwag.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace API
{
  /// <summary>
  /// 
  /// </summary>
  [Produces("application/json")]
  [Route("api/mensaje")]
  public class MensajeController : Controller
  {
    /// <summary>
    /// 
    /// </summary>
    protected readonly IMensajeRepository _mensajeRepository;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="mensajeRepository"></param>
    public MensajeController(IMensajeRepository mensajeRepository)
    {
      _mensajeRepository = mensajeRepository;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [Produces("application/json")]
    [AllowAnonymous]
    [HttpGet]
    [Route("getmensajes")]

    public ActionResult GetMensajes()
    {
      var ret = _mensajeRepository.GetMensajes();
      return Json(ret);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="CodMensaje"></param>
    /// <returns></returns>
    [Produces("application/json")]
    [AllowAnonymous]
    [HttpGet]
    [Route("getmensaje")]
    public ActionResult GetMensaje(string CodMensaje)
    {
      var ret = _mensajeRepository.GetMensaje(CodMensaje);
      return Json(ret);
    }

  }
}

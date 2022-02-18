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
  [Route("api/apartment")]
  [ApiController]
  public class ApartmentController : Controller
  {
    /// <summary>
    /// 
    /// </summary>
    protected readonly iApartmentRepository _apartmentRepository;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="apartmentRepository"></param>

    public ApartmentController(iApartmentRepository apartmentRepository)
    {
      _apartmentRepository = apartmentRepository;
    }


    /// <summary>
    /// 1er EndPoint
    /// </summary>
    /// <returns></returns>
    [Produces("application/json")]
    [AllowAnonymous]
    [HttpGet]
    [Route("getapartments")]
    public ActionResult GetApartments()
    {
      var ret = _apartmentRepository.GetApartments();
      return Json(ret);

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="CodDepartamento"></param>
    /// <returns></returns>

    [Produces("application/json")]
    [AllowAnonymous]
    [HttpGet]
    [Route("getapartment")]
    public ActionResult GetApartment(string CodDepartamento)
    {
      var ret =_apartmentRepository.GetApartment(CodDepartamento);
      return Json(ret);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="apartment"></param>
    /// <returns></returns>
    [Produces("application/json")]
    [AllowAnonymous]
    [HttpPost]
    [Route("insert")]

    public ActionResult Insert(EntityApartment apartment)
    {
      var ret = _apartmentRepository.Insert(apartment);
      return Json(ret);
    }
  }
}

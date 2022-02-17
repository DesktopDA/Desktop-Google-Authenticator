using API_WebApplication1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace API_WebApplication1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ApartmentController:ControllerBase
  {

    private readonly ApartmentContext _db;
    public ApartmentController(ApartmentContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult> GetApartments()
    {
      var listaApartment = await _db.Departamentos.OrderBy(c =>
      c.NumDepartamento).ToListAsync();

      return Ok(listaApartment);
    }
  }
}

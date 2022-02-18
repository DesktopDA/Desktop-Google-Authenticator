using Microsoft.AspNetCore.Mvc;

namespace UPC.APIBusiness.API.Controllers
{
  public class BookingController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}

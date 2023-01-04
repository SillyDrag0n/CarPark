using Microsoft.AspNetCore.Mvc;

namespace CarPark.Api.Controllers
{
    public class ParkingSpaceCheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("spaces/{id:string}")]
        public ActionResult Checkout(string id)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

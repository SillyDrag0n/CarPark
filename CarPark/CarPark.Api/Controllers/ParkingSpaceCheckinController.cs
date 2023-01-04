using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarPark.Api.Controllers
{
    public class ParkingSpaceCheckinController : Controller
    {
        // GET: ParkingSpaceCheckinController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("spaces/{id:string}")]
        public ActionResult Checkin(string id)
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

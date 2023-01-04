using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarPark.Api.Controllers
{
    public class ParkingSpacesController : Controller
    {
        // GET: ParkingSpacesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ParkingSpacesController/spaces/5
        [Route("spaces/{id ?}")]
        public ActionResult Spaces(string id)
        {
            return View();
        }

        // POST: ParkingSpacesController/spaces
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("spaces/{id ?}")]
        public ActionResult Spaces(IFormCollection collection)
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

        // DELETE: ParkingSpacesController/spaces/5
        [HttpDelete]
        [Route("spaces/{id:string}")]
        public ActionResult Delete(string id)
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

using System;
using System.Linq;
using System.Web.Mvc;

namespace RealityJinak.Controllers
{
    public class PriceController : Controller
    {
        // GET: Price
        public ActionResult Index()
        {
            ViewBag.Message = "Ceník služeb ";
            return View();
        }
    }
}
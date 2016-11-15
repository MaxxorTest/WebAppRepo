using System.Web.Mvc;

namespace SampleWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your test page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Your services page.";

            return View();
        }
    }
}
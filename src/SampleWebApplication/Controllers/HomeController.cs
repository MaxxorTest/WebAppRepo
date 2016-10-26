using System.Data.Entity.Core.Common.EntitySql;
using System.Web.Mvc;
using static System.Int32;

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

        public ActionResult TestResult()
        {
            var num1 = $"{Request.Form["Number1"]}";
            var num2 = $"{Request.Form["Number2"]}";

            var myNumbers = new MyNumbersModel
            {
                Number1 = Parse(num1),
                Number2 = Parse(num2)
            };

            return Json(myNumbers.AddThem(), JsonRequestBehavior.AllowGet);
        }

        private class MyNumbersModel
        {
            public int Number1;
            public int Number2;

            
            public string AddThem()
            {
                return (Number1 + Number2).ToString();
            }

        }
    }
}
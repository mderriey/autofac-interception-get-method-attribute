using System.Web.Mvc;

namespace AutofacInterceptionWithCache.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyQuery _myQuery;

        public HomeController(IMyQuery myQuery)
        {
            _myQuery = myQuery;
        }

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

        public ActionResult MyQuery()
        {
            return Json(_myQuery.GetName(), JsonRequestBehavior.AllowGet);
        }
    }
}
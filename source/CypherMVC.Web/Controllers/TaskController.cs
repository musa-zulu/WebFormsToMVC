using System.Web.Mvc;

namespace CypherMVC.Web.Controllers
{
    public class TaskController : Controller
    {
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateEdit()
        {
            return View();
        }
    }
}
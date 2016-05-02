using System.Web.Mvc;

namespace CypherMVC.Web.Controllers
{
    public class MessagesController : Controller
    {
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult Reply()
        {
            return View();
        }
    }
}
using System.Web.Mvc;

namespace TQJProject.Web.Controllers
{
    public class AboutController : TQJProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
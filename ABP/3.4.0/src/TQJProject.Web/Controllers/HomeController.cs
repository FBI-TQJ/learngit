using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TQJProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TQJProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
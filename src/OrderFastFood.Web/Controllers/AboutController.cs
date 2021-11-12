using System.Web.Mvc;

namespace OrderFastFood.Web.Controllers
{
    public class AboutController : OrderFastFoodControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
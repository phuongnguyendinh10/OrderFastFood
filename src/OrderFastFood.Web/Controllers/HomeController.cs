using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace OrderFastFood.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : OrderFastFoodControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
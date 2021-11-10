using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using OrderFastFoot.Controllers;

namespace OrderFastFoot.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : OrderFastFootControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

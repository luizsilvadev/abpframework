using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using App.ExemploMvc.Controllers;

namespace App.ExemploMvc.Web.Controllers
{
    public class AboutController : ExemploMvcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

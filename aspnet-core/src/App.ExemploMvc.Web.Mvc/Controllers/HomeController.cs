using Microsoft.AspNetCore.Mvc;
using App.ExemploMvc.Controllers;

namespace App.ExemploMvc.Web.Controllers
{
    public class HomeController : ExemploMvcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

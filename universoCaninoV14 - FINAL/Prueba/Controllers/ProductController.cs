using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers
{
    public class ProductController : Controller
    {
     
        public ActionResult Index()
        {
            return View();
        }
    }
}

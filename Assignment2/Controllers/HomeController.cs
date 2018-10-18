using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
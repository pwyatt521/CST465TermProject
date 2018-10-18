using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
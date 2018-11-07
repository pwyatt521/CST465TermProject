using System.Web;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class HHEditorForController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(ComputerModel mComputer){
            if (!ModelState.IsValid){
                return View(mComputer);
            }
            return View("Submission", mComputer);
        }
        public ActionResult Index()
        {
            return View(new ComputerModel());
        }
    }
}
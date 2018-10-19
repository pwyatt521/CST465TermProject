using System.Web;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public ActionResult ContactCreated(ContactModel mContact){
            if (!ModelState.IsValid){
                return View("Index",mContact);
            }
            return View(mContact);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
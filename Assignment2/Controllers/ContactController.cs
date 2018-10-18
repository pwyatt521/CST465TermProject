using System.Web;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public ActionResult ContactCreate(ContactModel mContact){
            if (!ModelState.IsValid){
                return View(mContact);
            }
            return View("ContactCreated",mContact);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
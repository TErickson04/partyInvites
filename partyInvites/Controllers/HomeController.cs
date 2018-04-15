using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using partyInvites.Models; //imported the partyInvites.Models namespace

namespace partyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        /* add HttpGet attribute */
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        /* Overload RsvpForm method with the httpPost attribute with GuestResponse parameter */
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // There is no error
                return View("Thanks", guestResponse);
            }
            else
            {
                // There is a validation error
                return View();
            }            
        }
    }
}
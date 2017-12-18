using CustomerChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMChatApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chat(Login model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Home Page";
                ViewBag.Username = model.UserNick;
                return View();
            }
            return View("Index");
        }
    }
}
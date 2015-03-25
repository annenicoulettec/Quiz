using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var context = new UsersContext();
            var username = User.Identity.Name;
            var user = context.UserProfiles.SingleOrDefault(u => u.UserName == username);
            ViewBag.Email = user.Email;

            return View();
        }
    }
}

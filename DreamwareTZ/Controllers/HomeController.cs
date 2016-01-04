using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DreamwareTZ.EntityModel;
using User = DreamwareTZ.Classes.User;

namespace DreamwareTZ.Controllers
{
    public class HomeController : Controller
    {

        private dreamDBEntities db = new dreamDBEntities();
        private User user = new User()
        {
            Login = "User",
            Password = "User",
            BirthDate = DateTime.Today.AddDays(-1),
            RegistrationDate = DateTime.Today
        };

        public ActionResult Index()
        {
            var users = db.Users.ToList();
            var admins = db.Admins.ToList();
            var a = new List<User>();
            a.Add(user);
            a.Add(user);

            var b = new List<object>();
            b.Add(user);
            b.Add(user);
            return View(b);
        }
    }


}
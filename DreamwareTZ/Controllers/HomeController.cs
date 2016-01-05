using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DreamwareTZ.EntityModel;
using User = DreamwareTZ.Models.User;

namespace DreamwareTZ.Controllers
{
    public class HomeController : Controller
    {
        private dreamContext db = new dreamContext();
        
        public ActionResult Index()
        {
            
            var users = db.Users.ToList();

            List<object> a = users.Cast<object>().ToList();

            return View(a);
        }
    }


}
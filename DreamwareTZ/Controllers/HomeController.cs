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
            return View(users.Cast<object>().ToList());
        }

        public ActionResult Index2()
        {
            var admins = db.Admins.ToList();
            return View("Index",admins.Cast<object>().ToList());
        }

        /*Create Update Delete*/
        
        public ActionResult Create(object obj, Type type)
        {
            return View("Index");
        }
        
        public ActionResult Update(object obj, Type type)
        {
            return View("Index");
        }
        
        public ActionResult Delete(object obj, Type type)
        {
            return View("Index");
        }
    }


}
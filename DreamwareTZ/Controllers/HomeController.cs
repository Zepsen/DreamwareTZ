using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DreamwareTZ.EntityModel;
using DreamwareTZ.Models;
using User = DreamwareTZ.Models.User;

namespace DreamwareTZ.Controllers
{
    public class HomeController : Controller
    {
        private dreamContext db = new dreamContext();
        
        public ActionResult Index()
        {
            var users = db.Users.ToList();

            var vmodel = new GridForViewModel()
            {
                TypeObj = users.First().GetType(),
                ListObj = users.Cast<object>().ToList()
            };

            return View(vmodel);
        }

        public ActionResult Index2()
        {
            var admins = db.Admins.ToList();

            var vmodel = new GridForViewModel()
            {
                TypeObj = admins.First().GetType(),
                ListObj = admins.Cast<object>().ToList()
            };

            return View("Index", vmodel);
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
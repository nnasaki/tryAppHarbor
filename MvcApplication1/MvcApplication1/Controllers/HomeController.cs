using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core.Model;
using Core.Persistence;


namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context = new Context();

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DbManipulate()
        {
            return View(_context.User2s);
        }

        public ActionResult Create(User2 user)
        {
            _context.User2s.Add(user);
            _context.SaveChanges();

            return RedirectToAction("DbManipulate");
        }
    }
}

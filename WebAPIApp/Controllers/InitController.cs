using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPIApp.Models;

namespace WebAPIApp.Controllers
{
    public class InitController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: Init
        public ActionResult Index()
        {
            Author a = new Author("Adam", "Mickiewicz");
            a.Id = 0;
            db.Authors.Add(a);
            a = new Author("Eliza", "Orzeszkowa");
            a.Id = 1;
            db.Authors.Add(a);
            db.SaveChanges();

            return View();
        }
    }
}

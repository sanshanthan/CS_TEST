using DBRelationshipsEF.ManyToManyRelationships;
using DBRelationshipsEF.OneToManyRelationships;
using DBRelationshipsEF.OneToOneRelationship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBRelationshipsEF.Controllers
{
    public class HomeController : Controller
    {
        OneToOneDbContext db = new OneToOneDbContext();
        OneToManyDbContext db2 = new OneToManyDbContext();
        ManyToManyDbContext db3 = new ManyToManyDbContext();

        public ActionResult Index()
        {    
            return View(db3.Students.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
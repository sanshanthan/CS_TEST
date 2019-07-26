using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UseSQLViewsWithEF.Models;

namespace UseSQLViewsWithEF.Controllers
{
    public class SqlViewController : Controller
    {
        // GET: SqlView
        public ActionResult Index()
        {
            ABC_Company_DBEntities2 ctx = new ABC_Company_DBEntities2();
            var result = ctx.EmpDetails;
            return View(result); ;
        }

        //string bccc = null;

        //    using (ABC_Company_DBEntities2 ctx = new ABC_Company_DBEntities2())
        //    {
        //        var result = from t in ctx.EmpDetails
        //                     select t;
        //        foreach (var t in result)
        //        {
        //            bccc = t.Developer_Name;
        //        }
        //    }
        //    return View(bccc);
    }
}
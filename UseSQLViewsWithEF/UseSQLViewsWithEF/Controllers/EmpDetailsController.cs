using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UseSQLViewsWithEF.Models;

namespace UseSQLViewsWithEF.Controllers
{
    public class EmpDetailsController : Controller
    {
        private ABC_Company_DBEntities2 db = new ABC_Company_DBEntities2();

        public  ObjectResult<getAllDetails_Result> getAllDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllDetails_Result>("getAllDetails");
        }
        // GET: EmpDetails
        public ActionResult Index()
        {
            EmpDetailsController emc = new EmpDetailsController();
            return View(db.EmpDetails.ToList());
        }
    }
}

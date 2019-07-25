using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingStoredProcedureMVC.Models;

namespace UsingStoredProcedureMVC.Controllers
{
    public class EmployeeController : Controller
    {
        Emp_Model mod = new Emp_Model();
        public ActionResult Index()
        {
            List<getAllDetails_Result> result = mod.GetEmployees();
            return View(result);
        }
    }
}
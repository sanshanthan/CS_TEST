using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsingStoredProcedureMVC.Models
{
    public class Emp_Model
    {
        ABC_Company_DBEntities db = new ABC_Company_DBEntities();
        public List<getAllDetails_Result> GetEmployees()
        {
            return db.getAllDetails().ToList();
        }
    }
}
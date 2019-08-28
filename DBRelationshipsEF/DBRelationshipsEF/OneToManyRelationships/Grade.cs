using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBRelationshipsEF.OneToManyRelationships
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
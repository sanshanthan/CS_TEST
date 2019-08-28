using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBRelationshipsEF.OneToOneRelationship
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual StudentAddress Address { get; set; }
    }
}
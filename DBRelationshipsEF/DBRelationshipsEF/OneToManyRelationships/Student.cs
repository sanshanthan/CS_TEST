using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBRelationshipsEF.OneToManyRelationships
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Grade Grade { get; set; }
    }
}
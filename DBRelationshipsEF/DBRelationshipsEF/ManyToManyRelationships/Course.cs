﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBRelationshipsEF.ManyToManyRelationships
{
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
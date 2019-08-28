using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DBRelationshipsEF.ManyToManyRelationships
{
    public class ManyToManyDbContext:DbContext
    {
        public ManyToManyDbContext():base("name=DefaultConnection3")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
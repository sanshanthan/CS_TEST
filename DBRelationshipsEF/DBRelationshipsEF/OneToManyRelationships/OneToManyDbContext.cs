using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DBRelationshipsEF.OneToManyRelationships
{
    public class OneToManyDbContext:DbContext
    {
        public OneToManyDbContext():base("name=DefaultConnection2")
        {

        }
        public DbSet<Student> studentss { get; set; }
        public DbSet<Grade> grades { get; set; }
    }
}
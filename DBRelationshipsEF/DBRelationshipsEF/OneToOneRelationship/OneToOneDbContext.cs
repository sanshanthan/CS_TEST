using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace DBRelationshipsEF.OneToOneRelationship
{
    public class OneToOneDbContext:DbContext
    {
        public OneToOneDbContext():base("name=DefaultConnection")
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentAddress> studentaddresses { get; set; }

    }
}
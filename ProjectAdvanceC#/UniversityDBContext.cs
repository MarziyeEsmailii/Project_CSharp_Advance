using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdvanceC_
{
    class UniversityDBContext:DbContext
    {

        public UniversityDBContext(string name):base(name) { }
        public DbSet<Student> students { get; set; }
        public DbSet<Employee>  employees { get; set; }
        public DbSet<Teacher>  teachers { get; set; }
        public DbSet<Lesson>  lessons { get; set; }
        public DbSet<Role> roles { get; set; }

    }
}

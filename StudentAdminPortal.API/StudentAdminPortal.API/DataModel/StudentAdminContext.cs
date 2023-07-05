using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.DataModel
{
    public class StudentAdminContext: DbContext
    {
        public StudentAdminContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Gender> Gender { get; set; }
    }
}

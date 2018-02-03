using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class StudentRegistrationDbContext : DbContext
    {
        public StudentRegistrationDbContext(DbContextOptions<StudentRegistrationDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentRegistration.Models.Student> Student { get; set; }
    }
}

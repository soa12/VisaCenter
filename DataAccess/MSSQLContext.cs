using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataAccess
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext(string connectionString) : base(connectionString)
        {

        }
      
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public static string _connectionString { get; set; }

        public ApplicationDbContext(string connectionString)
            : base(connectionString, throwIfV1Schema: false)
        {
            _connectionString = connectionString;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext(_connectionString);
        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<ApplicationForVisa> ApplicationForVisas { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

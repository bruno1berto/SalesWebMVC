using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

<<<<<<< HEAD
        public DbSet<SalesWebMVC.Models.Department> Department { get; set; }
=======
        public DbSet<SalesWebMVC.Models.Departments> Departments { get; set; }
>>>>>>> 4413869995234d2d35b59dc65edf5747a909a520
        public DbSet<SalesWebMVC.Models.Seller> Seller { get; set; }
        public DbSet<SalesWebMVC.Models.SalesRecord> SalesRecord { get; set; }
    }
}

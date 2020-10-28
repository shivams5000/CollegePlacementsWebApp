using CollegePlacementsWebApp.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegePlacementsWebApp.Data
{
    public class PlacementDataContext : DbContext
    {
        public PlacementDataContext(DbContextOptions<PlacementDataContext> options) : base(options)
        {

        }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Job> Jobs { get; set; }
    }
}

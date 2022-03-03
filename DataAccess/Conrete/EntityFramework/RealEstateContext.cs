using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RealEstateContext:DbContext
    {
        //public RealEstateContext(DbContextOptions<RealEstateContext> options):base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-V42T2II\SQLSERVER2019;Database=RealEstate;Trusted_Connection=True");
        }

        public DbSet<LandProperty> Lands { get; set; }
        public DbSet<HomeProperty> Homes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}

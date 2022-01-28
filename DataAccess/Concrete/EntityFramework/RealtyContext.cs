using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RealtyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Realtor;Trusted_Connection=True");
            //builder => builder.EnableRetryOnFailure());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Realty> Realties { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
    }
}

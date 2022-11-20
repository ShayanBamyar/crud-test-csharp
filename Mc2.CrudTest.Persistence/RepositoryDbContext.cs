using GemBox.Email.Mime;
using Mc2.CrudTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Persistence
{
    public class RepositoryDbContext : DbContext
    {
        public RepositoryDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Customer> CustomerRegistration { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                    .HasIndex(x => x.Email)
                    .IsUnique();

            modelBuilder.Entity<Customer>()
                    .HasIndex(x => new { x.FirstName, x.LastName ,x.DateOfBirth})
                    .IsUnique();

            modelBuilder.Entity<Customer>()
                    .HasIndex(x => new { x.FirstName, x.LastName, x.DateOfBirth });
        }

    }
}
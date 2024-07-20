using Microsoft.EntityFrameworkCore;
using ContactManager.Models;
using System.Collections.Generic;

namespace ContactManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor that takes DbContextOptions and passes them to the base DbContext class
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet representing the Contacts table in the database
        public DbSet<Contact> Contacts { get; set; }
    }
}

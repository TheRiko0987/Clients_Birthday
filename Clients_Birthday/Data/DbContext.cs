using Clients_Birthday.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clients_Birthday.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<customers> customer { get; set; } = null!;
        public DbSet<orders> order { get; set; } = null!;
        public DbSet<positions> position { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=Birthday_of_Customers; Username=postgres; Password=12345");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

    }
}

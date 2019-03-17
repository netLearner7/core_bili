using core_bili.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_bili.ef
{
    public class biliDbContext:DbContext
    {
        public biliDbContext(DbContextOptions<biliDbContext> options): base (options)
        {

        }

        public DbSet<User> logins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().ToTable(nameof(User));

        }
    }
}

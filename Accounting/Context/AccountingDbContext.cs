using Accounting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Context
{
    public class AccountingDbContext : DbContext
    {
        public AccountingDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<AccountType> AccountTypes { get; set; }
        DbSet<AccountCategory> AccountCategories { get; set; }
        DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(b => b.Active)
                .HasDefaultValue(true);
            modelBuilder.Entity<Account>()
                .Property(b => b.Checking)
                .HasDefaultValue(false);
        }
    }
}

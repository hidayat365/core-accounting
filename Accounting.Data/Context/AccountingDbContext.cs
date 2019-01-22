using Accounting.Data.Models;
using Accounting.Data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.Data.Context
{
    public class AccountingDbContext : DbContext
    {
        public AccountingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<AccountCategory> AccountCategories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(b => b.Active)
                .HasDefaultValue(true);
            modelBuilder.Entity<Account>()
                .Property(b => b.Checking)
                .HasDefaultValue(false);

            modelBuilder.Entity<Account>()
                .Property(b => b.CreatedOn)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Account>()
                .Property(b => b.ModifiedOn)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AccountType>()
                .Property(b => b.CreatedOn)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<AccountType>()
                .Property(b => b.ModifiedOn)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AccountCategory>()
                .Property(b => b.CreatedOn)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<AccountCategory>()
                .Property(b => b.ModifiedOn)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<AccountType>()
                .HasIndex(b => b.Code)
                .IsUnique();
            modelBuilder.Entity<AccountCategory>()
                .HasIndex(b => b.Code)
                .IsUnique();
            modelBuilder.Entity<Account>()
                .HasIndex(b => b.Code)
                .IsUnique();

            modelBuilder.Entity<AccountType>().HasData(
                new AccountType() { Id = 1, Code = "1000", Name = "Assets" },
                new AccountType() { Id = 2, Code = "2000", Name = "Liabilities" },
                new AccountType() { Id = 3, Code = "3000", Name = "Equities" },
                new AccountType() { Id = 4, Code = "4000", Name = "Income Statements" });

            modelBuilder.Entity<AccountCategory>().HasData(
                new AccountCategory() { Id = 11, Code = "1100", TypeId = 1, Name = "Current Assets" },
                new AccountCategory() { Id = 12, Code = "1200", TypeId = 1, Name = "Receivables" },
                new AccountCategory() { Id = 13, Code = "1300", TypeId = 1, Name = "Inventories" },
                new AccountCategory() { Id = 14, Code = "1400", TypeId = 1, Name = "Prepaid Expenses" },
                new AccountCategory() { Id = 15, Code = "1500", TypeId = 1, Name = "Fixed Assets" },
                new AccountCategory() { Id = 16, Code = "1600", TypeId = 1, Name = "Depreciations & Amortizations" },
                new AccountCategory() { Id = 17, Code = "1700", TypeId = 1, Name = "Non-Current Receivables" },
                new AccountCategory() { Id = 18, Code = "1800", TypeId = 1, Name = "Intercompany Receivables" },
                new AccountCategory() { Id = 19, Code = "1900", TypeId = 1, Name = "Other Assets" },
                new AccountCategory() { Id = 20, Code = "2100", TypeId = 2, Name = "Payables" },
                new AccountCategory() { Id = 21, Code = "2200", TypeId = 2, Name = "Expenses" },
                new AccountCategory() { Id = 22, Code = "2300", TypeId = 2, Name = "Accrued Expenses" },
                new AccountCategory() { Id = 23, Code = "2400", TypeId = 2, Name = "Other Expenses" },
                new AccountCategory() { Id = 24, Code = "2500", TypeId = 2, Name = "Accrued Taxes" },
                new AccountCategory() { Id = 25, Code = "2600", TypeId = 2, Name = "Deferred Taxes" },
                new AccountCategory() { Id = 26, Code = "2700", TypeId = 2, Name = "Long-Term Debt" },
                new AccountCategory() { Id = 27, Code = "2800", TypeId = 2, Name = "Intercompany Payables" },
                new AccountCategory() { Id = 28, Code = "2900", TypeId = 2, Name = "Other Liabilities" },
                new AccountCategory() { Id = 29, Code = "3100", TypeId = 3, Name = "Common Stock" },
                new AccountCategory() { Id = 30, Code = "3200", TypeId = 3, Name = "Preferred Stock" },
                new AccountCategory() { Id = 31, Code = "3300", TypeId = 3, Name = "Paid in Capital" },
                new AccountCategory() { Id = 32, Code = "3400", TypeId = 3, Name = "Partner Capital" },
                new AccountCategory() { Id = 33, Code = "3500", TypeId = 3, Name = "Member Contribution" },
                new AccountCategory() { Id = 34, Code = "3600", TypeId = 3, Name = "Drawings" },
                new AccountCategory() { Id = 35, Code = "3800", TypeId = 3, Name = "Current Earnings" },
                new AccountCategory() { Id = 36, Code = "3900", TypeId = 3, Name = "Retained Earnings" });

            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, Code = "IDR", Name = "Indonesia Rupiah" },
                new Currency() { Id = 2, Code = "USD", Name = "United States Dollar" });
        }
    }
}

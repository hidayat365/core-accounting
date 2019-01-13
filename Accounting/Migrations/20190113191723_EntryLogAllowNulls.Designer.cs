﻿// <auto-generated />
using System;
using Accounting.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Accounting.Migrations
{
    [DbContext(typeof(AccountingDbContext))]
    [Migration("20190113191723_EntryLogAllowNulls")]
    partial class EntryLogAllowNulls
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Accounting.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("BankAccountHolder")
                        .HasMaxLength(100);

                    b.Property<string>("BankAccountNumber")
                        .HasMaxLength(100);

                    b.Property<string>("BankAddress")
                        .HasMaxLength(200);

                    b.Property<string>("BankName")
                        .HasMaxLength(100);

                    b.Property<int>("CategoryId");

                    b.Property<bool?>("Checking")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("ParentId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Accounting.Models.AccountCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("TypeId");

                    b.ToTable("AccountCategories");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Code = "1100",
                            Name = "Current Assets",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 12,
                            Code = "1200",
                            Name = "Receivables",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            Code = "1300",
                            Name = "Inventories",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            Code = "1400",
                            Name = "Prepaid Expenses",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 15,
                            Code = "1500",
                            Name = "Fixed Assets",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 16,
                            Code = "1600",
                            Name = "Depreciations & Amortizations",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 17,
                            Code = "1700",
                            Name = "Non-Current Receivables",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 18,
                            Code = "1800",
                            Name = "Intercompany Receivables",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 19,
                            Code = "1900",
                            Name = "Other Assets",
                            TypeId = 1
                        },
                        new
                        {
                            Id = 20,
                            Code = "2100",
                            Name = "Payables",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 21,
                            Code = "2200",
                            Name = "Expenses",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 22,
                            Code = "2300",
                            Name = "Accrued Expenses",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 23,
                            Code = "2400",
                            Name = "Other Expenses",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 24,
                            Code = "2500",
                            Name = "Accrued Taxes",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 25,
                            Code = "2600",
                            Name = "Deferred Taxes",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 26,
                            Code = "2700",
                            Name = "Long-Term Debt",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 27,
                            Code = "2800",
                            Name = "Intercompany Payables",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 28,
                            Code = "2900",
                            Name = "Other Liabilities",
                            TypeId = 2
                        },
                        new
                        {
                            Id = 29,
                            Code = "3100",
                            Name = "Common Stock",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 30,
                            Code = "3200",
                            Name = "Preferred Stock",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 31,
                            Code = "3300",
                            Name = "Paid in Capital",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 32,
                            Code = "3400",
                            Name = "Partner Capital",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 33,
                            Code = "3500",
                            Name = "Member Contribution",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 34,
                            Code = "3600",
                            Name = "Drawings",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 35,
                            Code = "3800",
                            Name = "Current Earnings",
                            TypeId = 3
                        },
                        new
                        {
                            Id = 36,
                            Code = "3900",
                            Name = "Retained Earnings",
                            TypeId = 3
                        });
                });

            modelBuilder.Entity("Accounting.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("AccountTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "1000",
                            Name = "Assets"
                        },
                        new
                        {
                            Id = 2,
                            Code = "2000",
                            Name = "Liabilities"
                        },
                        new
                        {
                            Id = 3,
                            Code = "3000",
                            Name = "Equities"
                        },
                        new
                        {
                            Id = 4,
                            Code = "4000",
                            Name = "Income Statements"
                        });
                });

            modelBuilder.Entity("Accounting.Models.Account", b =>
                {
                    b.HasOne("Accounting.Models.AccountCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Accounting.Models.Account", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Accounting.Models.AccountCategory", b =>
                {
                    b.HasOne("Accounting.Models.AccountType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
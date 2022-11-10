using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using Totogen.Models.TotogenDb;

namespace Totogen.Data
{
  public partial class TotogenDbContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public TotogenDbContext(DbContextOptions<TotogenDbContext> options):base(options)
    {
    }

    public TotogenDbContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .HasOne(i => i.FeeArrangement1)
              .WithMany(i => i.Orders)
              .HasForeignKey(i => i.FeeArrangement)
              .HasPrincipalKey(i => i.FeeArrangementId);
        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .HasOne(i => i.Customer)
              .WithMany(i => i.Orders)
              .HasForeignKey(i => i.CustomerId)
              .HasPrincipalKey(i => i.CustomerId);
        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .HasOne(i => i.FeeStatus1)
              .WithMany(i => i.Orders)
              .HasForeignKey(i => i.FeeStatus)
              .HasPrincipalKey(i => i.FeeStatusId);


        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .Property(p => p.SampleExpectedDate)
              .HasColumnType("date");

        builder.Entity<Totogen.Models.TotogenDb.Customer>()
              .Property(p => p.CustomerId)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.Customer>()
              .Property(p => p.TotalOrders)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.FeeArrangement>()
              .Property(p => p.FeeArrangementId)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.FeeStatus>()
              .Property(p => p.FeeStatusId)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .Property(p => p.OrderId)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .Property(p => p.SamplesExpected)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .Property(p => p.FeeArrangement)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .Property(p => p.CustomerId)
              .HasPrecision(10, 0);

        builder.Entity<Totogen.Models.TotogenDb.Order>()
              .Property(p => p.FeeStatus)
              .HasPrecision(10, 0);
        this.OnModelBuilding(builder);
    }


    public DbSet<Totogen.Models.TotogenDb.Customer> Customers
    {
      get;
      set;
    }

    public DbSet<Totogen.Models.TotogenDb.FeeArrangement> FeeArrangements
    {
      get;
      set;
    }

    public DbSet<Totogen.Models.TotogenDb.FeeStatus> FeeStatuses
    {
      get;
      set;
    }

    public DbSet<Totogen.Models.TotogenDb.Order> Orders
    {
      get;
      set;
    }
  }
}

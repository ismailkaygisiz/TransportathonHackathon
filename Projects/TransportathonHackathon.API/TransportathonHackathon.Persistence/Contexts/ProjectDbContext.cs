﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TransportathonHackathon.Domain.Entities;
using TransportathonHackathon.Domain.Entities.Identity;

namespace TransportathonHackathon.Persistence.Contexts
{
    public class ProjectDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
            .HasOne(e => e.Company)
            .WithOne(e => e.AppUser)
            .HasForeignKey<Company>(e => e.AppUserId);

            builder.Entity<AppUser>()
            .HasOne(e => e.Customer)
            .WithOne(e => e.AppUser)
            .HasForeignKey<Customer>(e => e.AppUserId);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

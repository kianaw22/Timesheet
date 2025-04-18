﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Timesheet.Models.Entities;
using Timesheet.Models.Entities.Admin;
using Timesheet.Models.Entities.User;

namespace Timesheet.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Position> Position { get; set; }

        public DbSet<Models.Entities.User.Timesheet> Timesheet { get; set; }
       public DbSet<Counter_Table> Counter_Table { get; set; }
        public DbSet<Date> Date { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //seed roles

            builder.Entity<ApplicationRole>().HasData(
                    new ApplicationRole
                    {
                        Id = "1",
                        NormalizedName = "ADMIN",
                        Name = "Admin",
                    },
                    new ApplicationRole
                    {
                        Id = "2",
                        NormalizedName = "USER",
                        Name = "User",
                    }
                );

            //seed users
            var hasher = new PasswordHasher<ApplicationUser>();

            var adminUser = new ApplicationUser
            {
                Id = "admin-user-id", // Unique identifier for the admin user
                Name = "AdminName",
                Family = "AdminFamily",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                IsAdmin = true,
                Password = "Admin@123" // Store plain password for reference (testing only)
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, adminUser.Password);

            var normalUser = new ApplicationUser
            {
                Id = "normal-user-id", // Unique identifier for the regular user
                UserName = "user",
                NormalizedUserName = "USER",
                Name = "UserName",
                Family = "UserFamily",
                IsAdmin = false,
                Password = "User@123"
            };
            normalUser.PasswordHash = hasher.HashPassword(normalUser, normalUser.Password);

            builder.Entity<ApplicationUser>().HasData(adminUser, normalUser);

            // Seed user-role relationships
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1", // Admin role
                    UserId = "admin-user-id"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2", // User role
                    UserId = "normal-user-id"
                }
            );

        }
    }
}
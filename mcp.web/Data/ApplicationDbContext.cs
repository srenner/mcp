using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mcp.web.Models;

namespace mcp.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ProductHyperlink> ProductHyperlink { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectItem> ProjectItem { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<ProjectStatusHistory> ProjectStatusHistory { get; set; }
        public DbSet<ProjectStep> ProjectStep { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Project>()
                .HasOne(o => o.ProjectStatus)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ProjectStatusHistory>()
                .HasOne(o => o.ProjectStatus)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

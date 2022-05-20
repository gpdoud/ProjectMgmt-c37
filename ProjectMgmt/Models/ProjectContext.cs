using System;
using Microsoft.EntityFrameworkCore;

namespace ProjectMgmt.Models {

    public class ProjectContext : DbContext {

        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Work> Works { get; set; } = null!;
        public virtual DbSet<Resource> Resources { get; set; } = null!;

        public ProjectContext() { }
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlServer("server=localhost,1433;database=PrjDb;uid=sa;pwd=p@ssw0rd1#;");
        }

        protected override void OnModelCreating(ModelBuilder builder) {}
    }
}


using System;
using System.Collections.Generic;
using ApiWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace ApiWeb.DAL
{
    public class CUContext : DbContext
    {

        public CUContext() : base("ContosoUniversityEntities") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            Database.SetInitializer<CUContext>(null);
        }
    }
}
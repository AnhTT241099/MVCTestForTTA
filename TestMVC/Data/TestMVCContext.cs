using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace TestMVC.Data
{
    public class TestMVCContext : DbContext
    {
        public TestMVCContext (DbContextOptions<TestMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MvcMovie.Models.Shift> Shifts { get; set; }
        public DbSet<MvcMovie.Models.Shift> Doctors { get; set; }
        public DbSet<MvcMovie.Models.WorkShift> WorkShifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            modelBuilder.Entity<Shift>().HasKey(c => c.IdShift);
            modelBuilder.Entity<WorkShift>().HasKey(c => c.IdWork);
            modelBuilder.Entity<Doctor>().HasKey(c => c.Id);
            modelBuilder.Entity<WorkShift>().HasOne(a => a.Shift).WithMany(c => c.WorkShift).HasForeignKey(d => d.IdShift);
            modelBuilder.Entity<WorkShift>().HasOne(b => b.Doctor).WithMany(e => e.WorkShift).HasForeignKey(f => f.Id);
        }
    }
}

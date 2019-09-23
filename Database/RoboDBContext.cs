using System;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using tibber.robo.sanitycoveragelogger.DTO;

namespace tibber.robo.sanitycoveragelogger.Database
{
    public class RoboDBContext: DbContext
    {
        public RoboDBContext(DbContextOptions<RoboDBContext> options)
      : base(options)
        {

        }

        public DbSet<Executions> Executions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ExectuionsMap(modelBuilder.Entity<Executions>());
        }
    }
}

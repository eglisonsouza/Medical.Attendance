using Medical.Attendance.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medical.Attendance.Infra.Persistence.Configurations.SqlServer
{
    public sealed class SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : DbContext(options)
    {
        public DbSet<AttendanceMedical> AttendancesMedical { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<HourDay> HoursDays { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerDbContext).Assembly);
        }
    }
}

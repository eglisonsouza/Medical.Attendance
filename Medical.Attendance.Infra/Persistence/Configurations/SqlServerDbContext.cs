using Microsoft.EntityFrameworkCore;

namespace Medical.Attendance.Infra.Persistence.Configurations
{
    public sealed class SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlServerDbContext).Assembly);
        }
    }
}

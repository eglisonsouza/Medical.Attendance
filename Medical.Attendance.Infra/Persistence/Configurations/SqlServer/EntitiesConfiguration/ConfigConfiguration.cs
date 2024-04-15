using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Infra.Persistence.Configurations.SqlServer.EntitiesConfiguration.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.Configurations.SqlServer.EntitiesConfiguration
{
    public class ConfigConfiguration : BaseConfiguration<Config>
    {
        public new void Configure(EntityTypeBuilder<Config> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.IsWorkingHolidays)
                .IsRequired();

            builder
                .HasMany(p => p.WorkDays)
                .WithOne(p => p.Config)
                .HasForeignKey(p => p.ConfigId);
        }
    }
}

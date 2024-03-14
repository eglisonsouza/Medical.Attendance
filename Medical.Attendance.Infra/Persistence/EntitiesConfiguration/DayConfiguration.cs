using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Infra.Persistence.EntitiesConfiguration.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.EntitiesConfiguration
{
    public class DayConfiguration : BaseConfiguration<Day>
    {
        public new void Configure(EntityTypeBuilder<Day> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.DayName)
                .HasMaxLength(15)
                .IsRequired();

            builder
                .Property(p => p.Sequential)
                .HasMaxLength(1)
                .IsRequired();

            builder
                .HasMany(p => p.Hours)
                .WithOne(p => p.Day)
                .HasForeignKey(p => p.DayId)
                .IsRequired();

            builder
                .HasOne(p => p.Config)
                .WithMany(p => p.WorkDays)
                .HasForeignKey(p => p.ConfigId)
                .IsRequired();
        }
    }
}

using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Infra.Persistence.EntitiesConfiguration.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.EntitiesConfiguration
{
    public class HourDayConfiguration : BaseConfiguration<HourDay>
    {

        public new void Configure(EntityTypeBuilder<HourDay> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.Hour)
                .IsRequired();

            builder
                .Property(p => p.Sequential)
                .HasMaxLength(1)
                .IsRequired();

            builder
                .HasOne(p => p.Day)
                .WithMany(p => p.Hours)
                .HasForeignKey(p => p.DayId)
                .IsRequired();
        }
    }
}

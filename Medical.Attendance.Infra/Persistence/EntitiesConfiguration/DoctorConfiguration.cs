using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Infra.Persistence.EntitiesConfiguration.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.EntitiesConfiguration
{
    public class DoctorConfiguration : BaseConfiguration<Doctor>
    {
        public new void Configure(EntityTypeBuilder<Doctor> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).HasMaxLength(60).IsRequired();

            builder.HasOne(p => p.Config).WithMany().HasForeignKey(p => p.ConfigId);
        }
    }
}

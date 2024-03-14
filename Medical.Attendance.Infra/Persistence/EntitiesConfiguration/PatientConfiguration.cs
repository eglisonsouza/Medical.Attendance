using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Infra.Persistence.EntitiesConfiguration.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.EntitiesConfiguration
{
    public class PatientConfiguration : BaseConfiguration<Patient>
    {
        public new void Configure(EntityTypeBuilder<Patient> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.ClientId)
                .IsRequired();

            builder
                .Property(p => p.Name)
                .HasMaxLength(70)
                .IsRequired();

            builder
                .Property(p => p.Phone)
                .HasMaxLength(18)
                .IsRequired();
        }
    }
}
